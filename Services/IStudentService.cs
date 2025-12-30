using StudentResultAPI.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentResultAPI.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetAllStudentsAsync();
        Task<StudentDto?> GetStudentByIdAsync(string id);
        Task<IEnumerable<StudentDto>> SearchStudentsByNameAsync(string name);
        Task<StudentDto> CreateStudentAsync(CreateStudentDto createStudentDto);
        Task<bool> UpdateStudentAsync(string id, UpdateStudentDto updateStudentDto);
        Task<bool> DeleteStudentAsync(string id);
    }
}
