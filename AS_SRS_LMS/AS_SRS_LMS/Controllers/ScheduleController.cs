using AS_SRS_LMS.Data;
using AS_SRS_LMS.Models;
using AS_SRS_LMS.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS_SRS_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ScheduleController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IScheduleRepo _scheduleRepo;
        public ScheduleController(IScheduleRepo scheduleRepo, DataContext context)
        {
            _scheduleRepo = scheduleRepo;
            _context = context;
        }
        [HttpGet("get-schedule")]
        public ActionResult<IEnumerable<Schedule>> GetUsers()
        {
            var sche = _scheduleRepo.GetSchedule();
            return Ok(sche);
        }
        [HttpPost("add-schedule")]
        public IActionResult AddSchedule(ScheduleRequest schedule)
        {
            //if (_context.Schedules.Any(u => u.Email == request.Email))
            //{
            //    return BadRequest("User already exists.");
            //}
            _scheduleRepo.AddSchedule(schedule);
            return Ok(new { message = "Schedule created" });
        }
        [HttpGet("detail-schedule")]
        public IActionResult Detail(int id)
        {
            var sche = _scheduleRepo.DetailSchedule(id);
            if (id == 0)
            {
                return BadRequest("Vui lòng nhập id lịch học");
            }
            if (sche == null)
            {
                return BadRequest("Ko tìm thấy lịch học");
            }
            return Ok(sche);
        }
        [HttpPost("delete-schedule")]
        public IActionResult Delete(int id)
        {
            var sche = _scheduleRepo.DetailSchedule(id);
            if (id == 0)
            {
                return BadRequest("Vui lòng nhập id lịch học");
            }
            if (sche == null)
            {
                return BadRequest("Ko tìm thấy lịch học");
            }
            _scheduleRepo.RemoveSchedule(id);
            return Ok(new { massage = "Delete Successful !!!" });
        }
        [HttpPut("update-schedule")]
        public IActionResult Update(int id, ScheduleRequest schedule)
        {
            var sche = _scheduleRepo.DetailSchedule(id);
            if (id == 0)
            {
                return BadRequest("Vui lòng nhập id lịch học");
            }
            if (sche == null)
            {
                return BadRequest("Ko tìm thấy lịch học");
            }
            _scheduleRepo.UpdateSchedule(id,schedule);
            return Ok(new { massage = "Update Successful !!!" });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-learning-schedule")]
        public ActionResult<IEnumerable<LearningSchedule>> GetLearningSchedule()
        {
            var sche = _scheduleRepo.GetAllDetailSchedule();
            return Ok(sche);
        }
        [HttpPost("add-learning-schedule")]
        public IActionResult AddLearningSchedule(LearningScheduleRequest schedule)
        {
            //if (_context.Schedules.Any(u => u.Email == request.Email))
            //{
            //    return BadRequest("User already exists.");
            //}
            _scheduleRepo.AddDetailSchedule(schedule);
            return Ok(new { message = "Learning Schedule created" });
        }
        [HttpGet("detail-learning-schedule")]
        public IActionResult DetailLearningSchedule(int id)
        {
            var sche = _scheduleRepo.GetDetailSchedule(id);
            if (id == 0)
            {
                return BadRequest("Vui lòng nhập id lịch học");
            }
            if (sche == null)
            {
                return BadRequest("Ko tìm thấy lịch học");
            }
            return Ok(sche);
        }
        [HttpPost("delete-learning-schedule")]
        public IActionResult DeleteLearningSchedule(int id)
        {
            var sche = _scheduleRepo.GetDetailSchedule(id);
            if (id == 0)
            {
                return BadRequest("Vui lòng nhập id lịch học");
            }
            if (sche == null)
            {
                return BadRequest("Ko tìm thấy lịch học");
            }
            _scheduleRepo.RemoveDetailSchedule(id);
            return Ok(new { massage = "Delete Successful !!!" });
        }
        [HttpPut("update-learning-schedule")]
        public IActionResult UpdateLearningSchedule(int id, LearningScheduleRequest schedule)
        {
            var sche = _scheduleRepo.GetDetailSchedule(id);
            if (id == 0)
            {
                return BadRequest("Vui lòng nhập id lịch học");
            }
            if (sche == null)
            {
                return BadRequest("Ko tìm thấy lịch học");
            }
            _scheduleRepo.UpdateDetailSchedule(id, schedule);
            return Ok(new { massage = "Update Successful !!!" });
        }
    }
}
