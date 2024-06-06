using AutoBogus;
using Moq;
using Shouldly;
using StudentTrackSystem.Models;
using StudentTrackSystem.Services;

namespace StudentTrackSystem.Test
{
    public class StudentServiceTests
    {
        private readonly Mock<IRepository<Student>> _studentRepositoryMock;
        private readonly IStudentService _studentService;

        public StudentServiceTests()
        {
            _studentRepositoryMock = new Mock<IRepository<Student>>();
            _studentService = new StudentService(_studentRepositoryMock.Object);
        }

        [Fact]
        public void CreateStudent_ShouldAddStudent()
        {
            // Arrange
            var student = AutoFaker.Generate<Student>();

            // Act
            _studentService.CreateStudent(student);

            // Assert
            _studentRepositoryMock.Verify(repo => repo.Add(It.IsAny<Student>()), Times.Once);
        }

        [Fact]
        public void GetStudentById_ShouldReturnStudent()
        {
            // Arrange
            var student = AutoFaker.Generate<Student>();
            _studentRepositoryMock.Setup(repo => repo.GetById(student.Id)).Returns(student);

            // Act
            var result = _studentService.GetStudentById(student.Id);

            // Assert
            result.ShouldNotBeNull();
            result.ShouldBe(student);
        }
    }
}