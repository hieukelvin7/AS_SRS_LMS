using AS_SRS_LMS.Data;
using AS_SRS_LMS.Models;
using AS_SRS_LMS.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS_SRS_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IExamManager _examManager;
        public ExamController(IExamManager examManager, DataContext context)
        {
            _examManager = examManager;
            _context = context;
        }
        [HttpGet("get-all-exams")]
        public ActionResult<IEnumerable<Exam>> GetUsers()
        {
            var exam = _examManager.GetAllExams();
            return Ok(exam);
        }
        [HttpPost("create-exam")]
        public IActionResult AddExam(ExamRequest request)
        {
            _examManager.AddExam(request);
            return Ok(new { massage = "Created Successful !!!" });
        }
    }
}
