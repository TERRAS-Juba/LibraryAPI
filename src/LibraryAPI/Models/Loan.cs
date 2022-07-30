using System.ComponentModel.DataAnnotations;
namespace LibraryAPI.Models
{
    public class Loan
    {
        public int LoanID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfLoan { get; set; }
        [Required]
        public bool IsOver{get;set;}
        [Required]
        public int StudentID {get;set;}
        [Required]
        public int BookID{get;set;}
        [Required]
        public Student student{get;set;}
        [Required]
        public Book book{get;set;}

    }

}