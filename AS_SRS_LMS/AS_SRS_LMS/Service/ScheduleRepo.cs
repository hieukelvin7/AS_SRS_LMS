using AS_SRS_LMS.Data;
using AS_SRS_LMS.Models;

namespace AS_SRS_LMS.Service
{
    public class ScheduleRepo : IScheduleRepo
    {
        private readonly DataContext _context;
        
     
        public ScheduleRepo(DataContext context)
        {
            _context = context;
        }

        public void AddDetailSchedule(LearningScheduleRequest schedule)
        {
            var she = new LearningSchedule
            {
                LearningScheduleName = schedule.LearningScheduleName,
                DayOfWeek = schedule.DayOfWeek,
                StartDate = schedule.StartDate,
                EndDate = schedule.EndDate
            };
            _context.LearningSchedules.Add(she);
            _context.SaveChanges();
        }

        public void AddSchedule(ScheduleRequest schedule)
        {          
            var she = new Schedule
            {               
                SubjectId = schedule.SubjectId,
                ClassId = schedule.ClassId,
                LearningScheduleId = schedule.LearningScheduleId
            };
            _context.Schedules.Add(she);
            _context.SaveChanges();
        }

        public Schedule DetailSchedule(int id)
        {
            var sche = _context.Schedules.Find(id);
            return sche;
        }

        public List<LearningSchedule> GetAllDetailSchedule()
        {
            return _context.LearningSchedules.ToList();
        }

        public LearningSchedule GetDetailSchedule(int id)
        {
            var sche = _context.LearningSchedules.Find(id);
            return sche;
        }

        public List<Schedule> GetSchedule()
        {
            return _context.Schedules.ToList();
        }

        public void RemoveDetailSchedule(int id)
        {
            var sche = _context.LearningSchedules.Find(id);
            _context.LearningSchedules.Remove(sche);
            _context.SaveChanges();
        }

        public void RemoveSchedule(int id)
        {
            var sche = _context.Schedules.Find(id);
            _context.Schedules.Remove(sche);
            _context.SaveChanges();
        }

        public void UpdateDetailSchedule(int id, LearningScheduleRequest schedule)
        {
            var sche = _context.LearningSchedules.Find(id);
            sche.LearningScheduleName = schedule.LearningScheduleName;
            sche.DayOfWeek = schedule.DayOfWeek;
            sche.StartDate = schedule.StartDate;
            sche.EndDate = schedule.EndDate;
            _context.LearningSchedules.Update(sche);
            _context.SaveChanges();
        }

        public void UpdateSchedule(int id, ScheduleRequest schedule)
        {
            var sche = _context.Schedules.Find(id);
            sche.SubjectId = schedule.SubjectId;
            sche.ClassId = schedule.ClassId;
            sche.LearningScheduleId = schedule.LearningScheduleId;
            _context.Schedules.Update(sche);
            _context.SaveChanges();
        }
    }
}
