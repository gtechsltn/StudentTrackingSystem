namespace StudentTrackSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<ExamResult> ExamResults { get; set; } = new List<ExamResult>();
    }
}
