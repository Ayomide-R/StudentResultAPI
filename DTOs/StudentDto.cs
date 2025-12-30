namespace StudentResultAPI.DTOs
{
    public class StudentDto
    {
        public string? Id { get; set; }
        public required string Name { get; set; }
        public int Math { get; set; }
        public int English { get; set; }
        public int Science { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }
        public required string Grade { get; set; }
    }
}
