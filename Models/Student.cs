namespace StudentResultAPI.Models
{
    public class Student
    {
        public string? Id { get; set; } 

        public required string Name { get; set; }

        public int Math { get; set; }

        public int English { get; set; }

        public int Science { get; set; }

        public int Total => Math + English + Science;

        public double Average => Total / 3.0;

        public string Grade
        {
            get
            {
                if (Average >= 70) return "A";
                if (Average >= 60) return "B";
                if (Average >= 50) return "C";
                if (Average >= 45) return "D";
                if (Average >= 40) return "E";
                return "F";
            }
        }
    }
}
