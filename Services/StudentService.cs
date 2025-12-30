using StudentResultAPI.DTOs;
using StudentResultAPI.Models;
using StudentResultAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentResultAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<StudentDto>> GetAllStudentsAsync()
        {
            var students = await _repository.GetAllAsync();
            return students.Select(MapToDto);
        }

        public async Task<StudentDto?> GetStudentByIdAsync(string id)
        {
            var student = await _repository.GetByIdAsync(id);
            return student == null ? null : MapToDto(student);
        }

        public async Task<IEnumerable<StudentDto>> SearchStudentsByNameAsync(string name)
        {
            var students = await _repository.SearchByNameAsync(name);
            return students.Select(MapToDto);
        }

        public async Task<StudentDto> CreateStudentAsync(CreateStudentDto createStudentDto)
        {
            var student = new Student
            {
                Id = Guid.NewGuid().ToString(),
                Name = createStudentDto.Name,
                Math = createStudentDto.Math,
                English = createStudentDto.English,
                Science = createStudentDto.Science
            };

            await _repository.AddStudentAsync(student);
            return MapToDto(student);
        }

        public async Task<bool> UpdateStudentAsync(string id, UpdateStudentDto updateStudentDto)
        {
            var student = new Student
            {
                Name = updateStudentDto.Name,
                Math = updateStudentDto.Math,
                English = updateStudentDto.English,
                Science = updateStudentDto.Science
            };

            return await _repository.UpdateStudentAsync(id, student);
        }

        public async Task<bool> DeleteStudentAsync(string id)
        {
            return await _repository.DeleteStudentAsync(id);
        }

        private static StudentDto MapToDto(Student student)
        {
            return new StudentDto
            {
                Id = student.Id,
                Name = student.Name,
                Math = student.Math,
                English = student.English,
                Science = student.Science,
                Total = student.Total,
                Average = student.Average,
                Grade = student.Grade
            };
        }
    }
}
