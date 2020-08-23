using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryApp.ViewModels
{
    public class EditRoleViewModel
    {

        public EditRoleViewModel()
        {
            Users = new List<string>();

        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }


    }
}
