using StudentTrackSystem.Models;

namespace StudentTrackSystem.Services
{
    public interface IExamService
    {
        void CreateExam(Exam exam);
        void AddExamResult(ExamResult examResult);
    }
}
