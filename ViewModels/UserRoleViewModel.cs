using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InventoryApp.ViewModels
{
    public class UserRoleViewModel
    {
        public string UserId { get; set; }

        [DisplayName("Korisnik")]
        public string UserName { get; set; }
        public bool IsSelected { get; set; }
    }
}
