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
    public class ExamServiceTests
    {
        private readonly Mock<IRepository<Exam>> _examRepositoryMock;
        private readonly Mock<IRepository<ExamResult>> _examResultRepositoryMock;
        private readonly IExamService _examService;

        public ExamServiceTests()
        {
            _examRepositoryMock = new Mock<IRepository<Exam>>();
            _examResultRepositoryMock = new Mock<IRepository<ExamResult>>();
            _examService = new ExamService(_examRepositoryMock.Object, _examResultRepositoryMock.Object);
        }

        [Fact]
        public void CreateExam_ShouldAddExam()
        {
            // Arrange
            var exam = AutoFaker.Generate<Exam>();

            // Act
            _examService.CreateExam(exam);

            // Assert
            _examRepositoryMock.Verify(repo => repo.Add(It.IsAny<Exam>()), Times.Once);
        }

        [Fact]
        public void AddExamResult_ShouldAddResult()
        {
            // Arrange
            var examResult = AutoFaker.Generate<ExamResult>();

            // Act
            _examService.AddExamResult(examResult);

            // Assert
            _examResultRepositoryMock.Verify(repo => repo.Add(It.IsAny<ExamResult>()), Times.Once);
        }
    }
}
