using System.ComponentModel.DataAnnotations;

namespace SimpleMeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Telefon Numarası alanı zorunludur.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "E-Posta Adresi alanı zorunludur.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Katılım alanı zorunludur.")]
        public bool KatilimDurumu { get; set; }
    }
}
