using AS_SRS_LMS.Data;
using AS_SRS_LMS.Models;

namespace AS_SRS_LMS.Service
{
    public class ClassManager : IClassManager
    {
        private readonly DataContext _context;
        public ClassManager(DataContext context)
        {
            _context = context;
        }
        public void AddClass(ClassRequest request)
        {
            var cla = new Class
            {
                ClassName = request.ClassName,
                
            };
            _context.Classes.Add(cla);
            _context.SaveChanges();
        }

        public Class DetailClass(int id)
        {
            var cla = _context.Classes.Find(id);
            return cla;
        }

        public List<Class> GetAllClass()
        {
            return _context.Classes.ToList();
        }

        public void RemoveClass(int id)
        {
            var cla = _context.Classes.Find(id);
            _context.Classes.Remove(cla);
            _context.SaveChanges();
        }

        public void UpdateClass(int id, ClassRequest request)
        {
            var sub = _context.Classes.Find(id);
            sub.ClassName = request.ClassName;
            _context.Classes.Update(sub);
            _context.SaveChanges();
        }
    }
}
