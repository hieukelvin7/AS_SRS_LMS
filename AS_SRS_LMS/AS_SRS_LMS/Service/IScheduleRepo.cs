using AS_SRS_LMS.Models;

namespace AS_SRS_LMS.Service
{
    public interface IScheduleRepo
    {
        //Schedule
        List<Schedule> GetSchedule();
        void AddSchedule (ScheduleRequest schedule);
        void RemoveSchedule (int id);
        void UpdateSchedule (int id, ScheduleRequest schedule);
        Schedule DetailSchedule(int id);
        //Detail Schedule
        void AddDetailSchedule(LearningScheduleRequest schedule);
        void RemoveDetailSchedule(int id);
        void UpdateDetailSchedule(int id, LearningScheduleRequest schedule);
        LearningSchedule GetDetailSchedule(int id);
        List<LearningSchedule> GetAllDetailSchedule();
    }
}
