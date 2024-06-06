using AutoBogus;
using Moq;
using StudentTrackSystem.Models;
using StudentTrackSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTrackSystem.Test
{
    public class ClassServiceTests
    {
        private readonly Mock<IRepository<StudentClass>> _classRepositoryMock;
        private readonly IClassService _classService;

        public ClassServiceTests()
        {
            _classRepositoryMock = new Mock<IRepository<StudentClass>>();
            _classService = new ClassService(_classRepositoryMock.Object);
        }

        [Fact]
        public void CreateClass_ShouldAddClass()
        {
            // Arrange
            var studentClass = AutoFaker.Generate<StudentClass>();

            // Act
            _classService.CreateStudentClass(studentClass);

            // Assert
            _classRepositoryMock.Verify(repo => repo.Add(It.IsAny<StudentClass>()), Times.Once);
        }
    }
}
