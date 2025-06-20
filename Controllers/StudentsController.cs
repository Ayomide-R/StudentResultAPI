using Microsoft.AspNetCore.Mvc;
using StudentResultAPI.Models;
using StudentResultAPI.Repositories;

namespace StudentResultAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly StudentRepository _repo;

        public StudentsController(StudentRepository repo)
        {
            _repo = repo;
        }

        // Add new student
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _repo.AddStudent(student);
            return Created("", student);
        }

        // Get all students
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAll());
        }

        // Get student by ID
        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var student = _repo.GetById(id);
            if (student == null)
                return NotFound("Student not found");
            return Ok(student);
        }

        // Search by name
        [HttpGet("search")]
        public IActionResult SearchByName([FromQuery] string name)
        {
            var students = _repo.SearchByName(name);
            return Ok(students);
        }

        // Update student
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(string id, Student updatedStudent)
        {
            var success = _repo.UpdateStudent(id, updatedStudent);
            if (!success)
                return NotFound("Student not found");
            return Ok("Student updated successfully");
        }

        // Delete student
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(string id)
        {
            var success = _repo.DeleteStudent(id);
            if (!success)
                return NotFound("Student not found");
            return Ok("Student deleted successfully");
        }
    }
}
