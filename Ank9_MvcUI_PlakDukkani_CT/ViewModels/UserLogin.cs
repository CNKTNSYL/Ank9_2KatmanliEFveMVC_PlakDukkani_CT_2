using System.ComponentModel.DataAnnotations;

namespace Ank9_MvcUI_PlakDukkani_CT.ViewModels
{
    public class UserLogin
    {
        [Display(Name="Kullanıcı Adı:")]
        [Required(ErrorMessage = "Kullanıcı Adı boş bırakılamaz")]
        public string UserName { get; set; }

        [Display(Name = "Şifre:")]
        [Required(ErrorMessage ="Şifre boş bırakılamaz")]
        [StringLength(8,ErrorMessage ="Şifre 8 haneli olmalıdır")]
        [DataType(DataType.Password)]
        public int Password { get; set; }
    }
}
