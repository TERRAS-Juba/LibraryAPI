using LibraryAPI.Models;
namespace LibraryAPI.Data
{
    public interface IStudentRepository
    {
        bool saveChanges();
        IEnumerable<Student> GetAllStudent();
        Student GetStudentByID(int id);
        void CreateStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
    }
}