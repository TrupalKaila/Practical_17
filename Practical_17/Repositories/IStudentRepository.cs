using Practical_17.Models;

namespace Practical_17.Repositories
{
    public interface IStudentRepository
    {
        public IEnumerable<Students> GetAllStudents();
        public Students GetStudentById(int id);
        public void AddStudent(Students student);
        public void UpdateStudent(Students student);
        public void DeleteStudent(int id);
        public void SaveChanges();

    }
}
