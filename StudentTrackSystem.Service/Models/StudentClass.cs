namespace StudentTrackSystem.Models
{
    public class StudentClass
    {
        public int Id { get; set; }
        public string? ClassName { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
