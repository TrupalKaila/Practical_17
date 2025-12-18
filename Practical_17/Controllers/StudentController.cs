using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Practical_17.Models;
using Practical_17.Repositories;

namespace Practical_17.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        [Authorize(Roles = "Admin,NormalUser")]
        public IActionResult Index()
        {
            var students = _studentRepository.GetAllStudents();
            return View(students);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(Students student)
        {
            _studentRepository.AddStudent(student);
            _studentRepository.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            var student = _studentRepository.GetAllStudents().FirstOrDefault(s => s.StudentId == id);
            if (student != null)
            {
                return View(student);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(Students student)
        {
            _studentRepository.UpdateStudent(student);
            _studentRepository.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Authorize(Roles = "Admin,NormalUser")]
        public IActionResult Details(int id)
        {
            var student = _studentRepository.GetStudentById(id);
            return View(student);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var student = _studentRepository.GetStudentById(id);
            return View(student);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _studentRepository.DeleteStudent(id);
            _studentRepository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
