namespace StudentResultAPI.DTOs
{
    public class CreateStudentDto
    {
        public required string Name { get; set; }
        public int Math { get; set; }
        public int English { get; set; }
        public int Science { get; set; }
    }
}
