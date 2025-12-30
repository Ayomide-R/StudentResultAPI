using StudentResultAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentResultAPI.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllAsync();
        Task<Student?> GetByIdAsync(string id);
        Task<IEnumerable<Student>> SearchByNameAsync(string name);
        Task AddStudentAsync(Student student);
        Task<bool> UpdateStudentAsync(string id, Student student);
        Task<bool> DeleteStudentAsync(string id);
    }
}
