using AS_SRS_LMS.Data;
using AS_SRS_LMS.Models;
using AS_SRS_LMS.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS_SRS_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly ISubjectManager _subjectManager;

        public SubjectController(DataContext context, ISubjectManager subjectManager)
        {
            _context = context;
            _subjectManager = subjectManager;
        }
        [HttpPost("create-subject")]
        public IActionResult AddSubject(SubjectRequest request)
        {
             _subjectManager.AddSubject(request);
            return Ok(new { massage = "Created Successful !!!" });
        }
        [HttpGet("detail-subject")]
        public IActionResult Detail(int id)
        {
            var sub = _subjectManager.DetailSubject(id);
            if (id == 0)
            {
                return BadRequest("Vui lòng nhập id môn học");
            }
            if (sub == null)
            {
                return BadRequest("Ko tìm thấy môn học");
            }
            return Ok(sub);
        }
        [HttpGet("get-all-subject")]
        public ActionResult<IEnumerable<User>> GetAllSubject()
        {
            var sub = _subjectManager.GetAllSubject();
            return Ok(sub);
        }
        [HttpPost("delete-subject")]
        public IActionResult Delete(int id)
        {
            var sub = _subjectManager.DetailSubject(id);
            if (id == 0)
            {
                return BadRequest("Vui lòng nhập id môn học");
            }
            if (sub == null)
            {
                return BadRequest("Ko tìm thấy môn học");
            }
            _subjectManager.RemoveSubject(id);
            return Ok(new { massage = "Delete Successful !!!" });
        }
        [HttpPut("update-subject")]
        public IActionResult Update(int id,SubjectRequest request)
        {
            var sub = _subjectManager.DetailSubject(id);
            if (id == 0)
            {
                return BadRequest("Vui lòng nhập id môn học");
            }
            if (sub == null)
            {
                return BadRequest("Ko tìm thấy môn học");
            }
            _subjectManager.UpdateSubject(id,request);
            return Ok(new { massage = "Update Successful !!!" });
        }
    }
}
