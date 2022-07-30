using System.ComponentModel.DataAnnotations;
namespace LibraryAPI.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        public string YearOfStudy { get; set; }
        public ICollection<Loan> Loans{get;set;}
    }

}