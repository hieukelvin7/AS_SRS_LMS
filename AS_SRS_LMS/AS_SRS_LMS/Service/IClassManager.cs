using AS_SRS_LMS.Models;

namespace AS_SRS_LMS.Service
{
    public interface IClassManager
    {
        void AddClass(ClassRequest request);
        Class DetailClass(int id);
        List<Class> GetAllClass();
        void RemoveClass(int id);
        void UpdateClass(int id, ClassRequest request);
    }
}