using StudentTrackSystem.Models;

namespace StudentTrackSystem.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void CreateStudent(Student student)
        {
            _studentRepository.Add(student);
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetById(id);
        }
    }
}
