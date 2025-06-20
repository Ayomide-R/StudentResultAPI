using StudentResultAPI.Models;

namespace StudentResultAPI.Repositories
{
    public class StudentRepository
    {
        private readonly List<Student> _students = new();

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
            return _students.FirstOrDefault(s => s.ID == id);
        }

        public List<Student> SearchByName(string name)
        {
            return _students
                .Where(s => s.Name != null && s.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}