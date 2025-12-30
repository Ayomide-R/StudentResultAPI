using StudentResultAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentResultAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly List<Student> _students = new List<Student>();

        public Task AddStudentAsync(Student student)
        {
            _students.Add(student);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Student>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<Student>>(_students);
        }

        public Task<Student?> GetByIdAsync(string id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            return Task.FromResult(student);
        }

        public Task<IEnumerable<Student>> SearchByNameAsync(string name)
        {
            var results = _students
                .Where(s => !string.IsNullOrEmpty(s.Name) && s.Name.ToLower().Contains(name.ToLower()))
                .ToList();
            return Task.FromResult<IEnumerable<Student>>(results);
        }

        public Task<bool> UpdateStudentAsync(string id, Student updatedStudent)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return Task.FromResult(false);

            student.Name = updatedStudent.Name;
            student.Math = updatedStudent.Math;
            student.English = updatedStudent.English;
            student.Science = updatedStudent.Science;

            return Task.FromResult(true);
        }

        public Task<bool> DeleteStudentAsync(string id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return Task.FromResult(false);

            _students.Remove(student);
            return Task.FromResult(true);
        }
    }
}