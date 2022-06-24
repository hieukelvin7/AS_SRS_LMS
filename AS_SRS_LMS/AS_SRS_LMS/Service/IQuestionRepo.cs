using AS_SRS_LMS.Models;

namespace AS_SRS_LMS.Service
{
    public interface IQuestionRepo
    {
        void AddQuestion(QuestionRequest request);
        void DetailQuestion(int id);
        void RemoveQuestion(int id);
        List<Question> GetAllQuestions();
    }
}
