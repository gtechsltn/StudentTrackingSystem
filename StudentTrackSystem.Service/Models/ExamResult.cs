namespace StudentTrackSystem.Models
{
    public class ExamResult
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public double Score { get; set; }
    }
}
