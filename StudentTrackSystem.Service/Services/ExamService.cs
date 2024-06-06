using StudentTrackSystem.Models;

namespace StudentTrackSystem.Services
{
    public class ExamService : IExamService
    {
        private readonly IRepository<Exam> _examRepository;
        private readonly IRepository<ExamResult> _examResultRepository;

        public ExamService(IRepository<Exam> examRepository, IRepository<ExamResult> examResultRepository)
        {
            _examRepository = examRepository;
            _examResultRepository = examResultRepository;
        }

        public void CreateExam(Exam exam)
        {
            _examRepository.Add(exam);
        }

        public void AddExamResult(ExamResult examResult)
        {
            _examResultRepository.Add(examResult);
        }
    }
}
