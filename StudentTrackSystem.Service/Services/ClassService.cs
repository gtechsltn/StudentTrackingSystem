using StudentTrackSystem.Models;

namespace StudentTrackSystem.Services
{
    public class ClassService : IClassService
    {
        private readonly IRepository<StudentClass> _classRepository;

        public ClassService(IRepository<StudentClass> classRepository)
        {
            _classRepository = classRepository;
        }

        public void CreateStudentClass(StudentClass studentClass)
        {
            _classRepository.Add(studentClass);
        }
    }
}
