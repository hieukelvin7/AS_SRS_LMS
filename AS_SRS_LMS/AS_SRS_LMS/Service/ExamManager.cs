using AS_SRS_LMS.Data;
using AS_SRS_LMS.Models;

namespace AS_SRS_LMS.Service
{
    public class ExamManager : IExamManager
    {
        private readonly DataContext _context;
        public ExamManager(DataContext context)
        {
            _context = context;
        }
        public void AddExam(ExamRequest request)
        {
           var exam = new Exam();
            {
                exam.ExamName = request.ExamName;
                exam.ExamDate = request.ExamDate;
                exam.Status = false;
                exam.TypeExamId = request.TypeExamId;
            }
            _context.Exams.Add(exam);
            _context.SaveChanges();
        }

        public Exam DetailExam(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Exam> GetAllExams()
        {

            return _context.Exams.ToList();
        }

        public void RemoveExam(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateExam(int id, ExamRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
