using AS_SRS_LMS.Data;
using AS_SRS_LMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS_SRS_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly DataContext _context;

        public ClassController(DataContext context)
        {
            _context = context;
        }
        [HttpPost("create-class")]
        public async Task<IActionResult> Register(ClassAddRequest request)
        {
            if (_context.Classes.Any(u => u.ClassName == request.ClassName))
            {
                return BadRequest("Class already exists");
            }
            
            var cla = new Class
            {
                ClassName = request.ClassName,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                SubjectId = request.SubjectId,
                
            };
            _context.Classes.Add(cla);
            await _context.SaveChangesAsync();
            return Ok("Class Successfully created");
        }
    }
}
