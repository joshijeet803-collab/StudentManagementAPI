using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private static List<Student> students = new()
        {
            new Student { Id = 1, Name = "Jeet Joshi", Branch = "CE", CGPA = 8.5, Email = "jeet@gmail.com" },
            new Student { Id = 2, Name = "Preet Vora", Branch = "CE", CGPA = 8.2, Email = "preet@gmail.com" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAll() => Ok(students);

        [HttpGet("{id}")]
        public ActionResult<Student> GetById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound("Student not found.");
            return Ok(student);
        }

        [HttpPost]
        public ActionResult<Student> Add(Student student)
        {
            student.Id = students.Count == 0 ? 1 : students.Max(s => s.Id) + 1;
            students.Add(student);
            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Student updated)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound("Student not found.");
            student.Name = updated.Name;
            student.Branch = updated.Branch;
            student.CGPA = updated.CGPA;
            student.Email = updated.Email;
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound("Student not found.");
            students.Remove(student);
            return Ok("Student deleted successfully.");
        }
    }
}
