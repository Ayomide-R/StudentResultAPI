using Microsoft.AspNetCore.Mvc;
using StudentResultAPI.DTOs;
using StudentResultAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentResultAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentsController(IStudentService service)
        {
            _service = service;
        }

        // Add new student
        [HttpPost]
        public async Task<ActionResult<StudentDto>> AddStudent(CreateStudentDto createStudentDto)
        {
            var student = await _service.CreateStudentAsync(createStudentDto);
            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }

        // Get all students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetAll()
        {
            var students = await _service.GetAllStudentsAsync();
            return Ok(students);
        }

        // Get student by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDto>> GetById(string id)
        {
            var student = await _service.GetStudentByIdAsync(id);
            if (student == null)
                return NotFound("Student not found");
            return Ok(student);
        }

        // Search by name
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<StudentDto>>> SearchByName([FromQuery] string name)
        {
            var students = await _service.SearchStudentsByNameAsync(name);
            return Ok(students);
        }

        // Update student
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(string id, UpdateStudentDto updateStudentDto)
        {
            var success = await _service.UpdateStudentAsync(id, updateStudentDto);
            if (!success)
                return NotFound("Student not found");
            return Ok("Student updated successfully");
        }

        // Delete student
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(string id)
        {
            var success = await _service.DeleteStudentAsync(id);
            if (!success)
                return NotFound("Student not found");
            return Ok("Student deleted successfully");
        }
    }
}
