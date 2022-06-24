using AS_SRS_LMS.Data;
using AS_SRS_LMS.Models;
using AS_SRS_LMS.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS_SRS_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IClassManager _classManager;

        public ClassController(DataContext context, IClassManager classManager)
        {
            _context = context;
            _classManager = classManager;
        }
        [HttpPost("create-class")]
        public IActionResult AddClass(ClassRequest request)
        {
            _classManager.AddClass(request);
            return Ok(new { massage = "Created Successful !!!" });
        }
        [HttpGet("detail-class")]
        public IActionResult DetailClass(int id)
        {
            var cla = _classManager.DetailClass(id);
            if (id == 0)
            {
                return BadRequest("Vui lòng nhập id lớp học");
            }
            if (cla == null)
            {
                return BadRequest("Ko tìm thấy lớp học");
            }
            return Ok(cla);
        }
        [HttpGet("get-all-class")]
        public ActionResult<IEnumerable<Class>> GetAllSubject()
        {
            var cla = _classManager.GetAllClass();
            return Ok(cla);
        }
        [HttpPost("delete-class")]
        public IActionResult Delete(int id)
        {
            var cla = _classManager.DetailClass(id);
            if (id == 0)
            {
                return BadRequest("Vui lòng nhập id môn học");
            }
            if (cla == null)
            {
                return BadRequest("Ko tìm thấy môn học");
            }
            _classManager.RemoveClass(id);
            return Ok(new { massage = "Delete Successful !!!" });
        }
        [HttpPut("update-class")]
        public IActionResult Update(int id, ClassRequest request)
        {
            var cla = _classManager.DetailClass(id);
            if (id == 0)
            {
                return BadRequest("Vui lòng nhập id lớp học");
            }
            if (cla == null)
            {
                return BadRequest("Ko tìm thấy lớp học");
            }
            _classManager.UpdateClass(id, request);
            return Ok(new { massage = "Update Successful !!!" });
        }
    }
}
