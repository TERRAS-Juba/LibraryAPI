using LibraryAPI.Models;
namespace LibraryAPI.Data
{
    public class SqlStudentRepository : IStudentRepository
    {
        public void CreateStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudent()
        {
            return new List<Student>
            {
                new Student
            {
                StudentID=1,
                FirstName="TERRAS",
                LastName="Juba",
                Email="jubaterras600@gmail.com",
                PhoneNumber="0541251311",
                YearOfStudy="2CS",
                Loans=new List<Loan>()
            },new Student
            {
                StudentID=2,
                FirstName="AMOKRANE",
                LastName="ILhem",
                Email="ii_amokrane@gmail.com",
                PhoneNumber="0542853281",
                YearOfStudy="2CS",
                Loans=new List<Loan>()
            }
        };
    }

        public Student GetStudentByID(int id)
        {
            return new Student
            {
                StudentID = 1,
                FirstName = "TERRAS",
                LastName = "Juba",
                Email = "jubaterras600@gmail.com",
                PhoneNumber = "0541251311",
                YearOfStudy = "2CS",
                Loans = new List<Loan>()
            };
        }

        public bool saveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}