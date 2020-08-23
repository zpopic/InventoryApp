using InventoryApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryApp.Controllers
{



    //[Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        
        
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

      
        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {

            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Administration");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }


            return View(model);
        }

        [HttpGet]
        public IActionResult ListUsers()
        {
            var users = userManager.Users;

            return View(users);
        }


        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;

            return View(roles);
        }


        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rola s Id-om = {id} ne postoji";
                return View("NotFound");
            }

            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name

            };

            foreach (var user in await userManager.Users.ToListAsync())
            //ovdje iznda inače ne ide await i .ToListAsync(), ali smo pretvorili cijeli user manager u async jer inače nije po defaultu pa baca grešku otvorenog DataReadera: https://www.youtube.com/watch?v=7ikyZk5fGzk

            {
                if (await userManager.IsInRoleAsync(user, role.Name))
                {

                    model.Users.Add(user.UserName); //model je tu ova instanca gore var model =...

                }
            }

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rola s Id-om = {model.Id} ne postoji";
                return View("NotFound");
            }
            else
            {
                role.Name = model.RoleName;

                var result = await roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model); // ovdje savljamo View model jer ga renderiramo na svaku pogrešku!

            }

        }

        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleID)
        {
            ViewBag.roleId = roleID;

            var role = await roleManager.FindByIdAsync(roleID);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rola s Id-om = {role.Id} ne postoji";
                return View("NotFound");
            }

            var model = new List<UserRoleViewModel>();

            foreach (var user in await userManager.Users.ToListAsync()) // dodano je .ToListAsync() na userManager.Users jer kenja zbog otvorenog datareadera!
            {
                var UserRoleViewModel = new UserRoleViewModel
                {

                    UserId = user.Id,
                    UserName = user.UserName

                };
                // sad moramo provjeriti je li user u roli ili nije, ako je da mu IsSelected kljukica bude zakljukana!
                // inače kljukica nije zakljukana, ako nije dio te role

                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    UserRoleViewModel.IsSelected = true;
                }
                else
                {
                    UserRoleViewModel.IsSelected = false;
                }

                model.Add(UserRoleViewModel);

            }

            return View(model);

        }

        [HttpPost]

        public async Task<IActionResult> EditUsersInRole (List<UserRoleViewModel>model, string roleId)
        {

            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)

            {
                ViewBag.ErrorMessage = $"Rola s Id-om = {roleId} ne postoji";
                return View("NotFound");

            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                if (model[i].IsSelected &&  !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i<(model.Count-1))
                    {
                        continue;
                    }
                    else
                    {
                        return RedirectToAction("EditRole", new { Id = roleId });
                    }
                }
            }


            return RedirectToAction("EditRole", new { Id = roleId });

        
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"Korisnik s Id-om = {id} ne postoji";
                return View("NotFound");
            } else
            {
                var deluser = await userManager.DeleteAsync(user);
                if (deluser.Succeeded)
                {
                    return RedirectToAction("ListUsers");
                }
                foreach (var error in deluser.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View("ListUsers");
            }
        }


        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rola s Id-om = {id} ne postoji";
                return View("NotFound");
            }
            else
            {
                var delrole = await roleManager.DeleteAsync(role);
                if (delrole.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }
                foreach (var error in delrole.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View("ListRoles");
            }
        }

    }
}
