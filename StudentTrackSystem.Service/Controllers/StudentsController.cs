using Microsoft.AspNetCore.Mvc;
using StudentTrackSystem.Models;
using StudentTrackSystem.Services;

namespace StudentTrackSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("create-student")]
        public IActionResult CreateStudent(Student student)
        {
            _studentService.CreateStudent(student);
            return Ok("Student created successfully.");
        }

        [HttpGet("get-student/{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _studentService.GetStudentById(id);
            return student != null ? Ok(student) : NotFound();
        }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class ClassesController : ControllerBase
    {
        private readonly IClassService _classService;

        public ClassesController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpPost("create-class")]
        public IActionResult CreateClass(StudentClass studentClass)
        {
            _classService.CreateStudentClass(studentClass);
            return Ok("Class created successfully.");
        }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class ExamsController : ControllerBase
    {
        private readonly IExamService _examService;

        public ExamsController(IExamService examService)
        {
            _examService = examService;
        }

        [HttpPost("create-exam")]
        public IActionResult CreateExam(Exam exam)
        {
            _examService.CreateExam(exam);
            return Ok("Exam created successfully.");
        }

        [HttpPost("add-exam-result")]
        public IActionResult AddExamResult(ExamResult examResult)
        {
            _examService.AddExamResult(examResult);
            return Ok("Exam result added successfully.");
        }
    }

}
