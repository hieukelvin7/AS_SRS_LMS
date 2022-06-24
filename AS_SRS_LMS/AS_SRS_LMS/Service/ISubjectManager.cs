using AS_SRS_LMS.Models;

namespace AS_SRS_LMS.Service
{
    public interface ISubjectManager
    {
        void AddSubject(SubjectRequest request);
        void RemoveSubject(int id);
        void UpdateSubject(int id, SubjectRequest request);
        Subject DetailSubject(int id);
        List<Subject> GetAllSubject();
    }
}
