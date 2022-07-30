using System.ComponentModel.DataAnnotations;
namespace LibraryAPI.Models
{
    public class Book
    {
        public int BookID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Author { get; set; }
        [Required]
        [MaxLength(100)]
        public string Field { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public bool IsPraised{get;set;}
        public ICollection<Loan>Loans;
    }

}