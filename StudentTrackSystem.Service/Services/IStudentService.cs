using StudentTrackSystem.Models;

namespace StudentTrackSystem.Services
{
    public interface IStudentService
    {
        void CreateStudent(Student student);
        Student GetStudentById(int id);
    }
}
