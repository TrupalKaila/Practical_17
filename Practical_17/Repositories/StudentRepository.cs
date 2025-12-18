using Microsoft.EntityFrameworkCore;
using Practical_17.Data;
using Practical_17.Models;

namespace Practical_17.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _appDbContext;
        public StudentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Students> GetAllStudents()
        {
            return _appDbContext.Students.ToList();
        }

        public Students GetStudentById(int id)
        {
            return _appDbContext.Students.FirstOrDefault(std => std.StudentId == id);
        }
        public void AddStudent(Students student)
        {
            _appDbContext.Add(student);
        }

        public void UpdateStudent(Students student)
        {
            _appDbContext.Students.Update(student);
        }


        public void DeleteStudent(int id)
        {
            var student = _appDbContext.Students.FirstOrDefault(std => std.StudentId == id);
            if (student != null)
            {
                _appDbContext.Remove(student);
            }
        }

        public void SaveChanges()
        {
            _appDbContext.SaveChanges();
        }
    }
}