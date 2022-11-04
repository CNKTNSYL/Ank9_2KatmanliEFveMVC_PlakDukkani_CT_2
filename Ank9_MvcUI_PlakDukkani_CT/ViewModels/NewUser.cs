using Ank9_EF_Entities_CT.Entities;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ank9_MvcUI_PlakDukkani_CT.ViewModels
{
    public class NewUser
    {
        [Display(Name = "Kullanıcı Adı:")]
        [Required(ErrorMessage = "Kullanıcı Adı boş bırakılamaz")]
        public string UserName { get; set; }

        [Display(Name = "Şifre:")]
        [Required(ErrorMessage = "Şifre boş bırakılamaz")]
        [StringLength(8, ErrorMessage = "Şifre 8 haneli olmalıdır")]
        [DataType(DataType.Password)]
        [Compare("RepeatPassword",ErrorMessage = "Girdiğiniz şifreler eşleşmiyor")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar:")]
        [Required(ErrorMessage = "Şifre boş bırakılamaz")]
        [StringLength(8, ErrorMessage = "Şifre 8 haneli olmalıdır")]
        [DataType(DataType.Password)]
        public string RepeatPassword { get; set; }

        public User GetUser()
        {
            return new User()
            {
                Name = this.UserName,
                Password = this.Password
            };
        }
    }
}
