using System.ComponentModel.DataAnnotations;

namespace InventoryApp.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
