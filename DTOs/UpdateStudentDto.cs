namespace StudentResultAPI.DTOs
{
    public class UpdateStudentDto
    {
        public required string Name { get; set; }
        public int Math { get; set; }
        public int English { get; set; }
        public int Science { get; set; }
    }
}
