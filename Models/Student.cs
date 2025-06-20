namespace StudentResultAPI.Models
{
    public class Student
    {
        public string? Name { get; set; }
        public required string ID { get; set; }
        public int Math { get; set; }
        public int English { get; set; }
        public int Science { get; set; }

        public int Total => Math + English + Science;

        public double Average => Total / 3.0;

        public string Grade
        {
            get
            {
                var avg = Average;
                if (avg >= 70) return "A";
                else if (avg >= 60) return "B";
                else if (avg >= 50) return "C";
                else if (avg >= 45) return "D";
                else if (avg >= 40) return "E";
                else return "F";
            }
        }
    }
}
