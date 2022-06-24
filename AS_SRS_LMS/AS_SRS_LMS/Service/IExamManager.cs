using AS_SRS_LMS.Models;

namespace AS_SRS_LMS.Service
{
    public interface IExamManager
    {
        void AddExam(ExamRequest request);
        void RemoveExam(int id);
        void UpdateExam(int id, ExamRequest request);
        Exam DetailExam(int id);
        ICollection<Exam> GetAllExams();

        //Content Exam
        void AddContentExam(ExamRequest request);

    }
}
