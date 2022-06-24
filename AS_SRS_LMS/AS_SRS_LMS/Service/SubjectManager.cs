using AS_SRS_LMS.Data;
using AS_SRS_LMS.Models;
namespace AS_SRS_LMS.Service
{
    public class SubjectManager : ISubjectManager
    {
        private readonly DataContext _context;
        public SubjectManager(DataContext context)
        {
            _context = context;
        }
        public void AddSubject(SubjectRequest request)
        {          
            var sub = new Subject
            {
                SubjectName = request.SubjectName,
                NumberOfPeriod = request.NumberOfPeriod
            };
            _context.Subjects.Add(sub);
            _context.SaveChanges();
        }

        public Subject DetailSubject(int id)
        {
             var sub = _context.Subjects.Find(id);
            return sub;
        }

        public List<Subject> GetAllSubject()
        {
            return _context.Subjects.ToList();
        }

        public void RemoveSubject(int id)
        {
            var sub = _context.Subjects.Find(id);
            _context.Subjects.Remove(sub);
            _context.SaveChanges();
        }

        public void UpdateSubject(int id, SubjectRequest request)
        {
            var sub = _context.Subjects.Find(id);
            sub.SubjectName = request.SubjectName;
             sub.NumberOfPeriod = request.NumberOfPeriod ;          
            _context.Subjects.Update(sub);
            _context.SaveChanges();
        }

    }
}
