using StudentResultAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentResultAPI.Repositories
{
    public class StudentRepository
    {
        private readonly List<Student> _students = new List<Student>();

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student? GetById(string id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public List<Student> SearchByName(string name)
        {
            return _students
                .Where(s => !string.IsNullOrEmpty(s.Name) && s.Name.ToLower().Contains(name.ToLower()))
                .ToList();
        }

        public bool UpdateStudent(string id, Student updatedStudent)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return false;

            student.Name = updatedStudent.Name;
            student.Math = updatedStudent.Math;
            student.English = updatedStudent.English;
            student.Science = updatedStudent.Science;

            return true;
        }

        public bool DeleteStudent(string id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return false;

            _students.Remove(student);
            return true;
        }
    }
}