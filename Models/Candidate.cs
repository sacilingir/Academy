

using System.ComponentModel.DataAnnotations;

namespace Academy.Models{

    
    public class Candidate{
        [Required(ErrorMessage = "Email gereklidir.")]
        public String? Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "Ad gereklidir.")]
        public String? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage = "Soyisim gereklidir.")]
        public String? LastName { get; set; } = String.Empty;
        public String FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; } 
        [Required(ErrorMessage = "Kurs gereklidir.")]
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate(){
            ApplyAt=DateTime.Now;
        }

    }
}