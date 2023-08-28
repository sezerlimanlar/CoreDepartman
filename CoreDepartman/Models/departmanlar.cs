using System.ComponentModel.DataAnnotations;

namespace CoreDepartman.Models
{
    public class departmanlar
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Lütfen Birim Adını Boş Bırakmayınız.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Birim Ad alanı 2-50 karakter arası olmalıdır.")]
        public string DepartmanAd { get; set; }




    }
}
