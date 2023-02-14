namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ICopySubjectInClass
    {
        //Task<IQueryable<LessonCP>> GetAllLessonCP();
        //Task<IQueryable<LessonContentCP>> GetAllLessonContentCP();
        //Task<IQueryable<ResourceLink>> GetAllResourceLinkCP();
        //Task<IQueryable<SubjectCP>> GetAllSubjectCP();
        //Task<IQueryable<QuizCP>> GetAllQuizCP();
        //Task<IQueryable<QuizQuestionCP>> GetAllQuizQuestionCP();
        //Task<IQueryable<QuizQuestionQuizCP>> GetAllQuizQuestionQuizCP();
        //Task<IQueryable<QuizAnswerCP>> GetAllQuizAnswerCP();

        //Task<IQueryable<QuestionType>> GetAllQuestionType();


        //Task<IQueryable<LessonUP>> GetAllLessonUP();
        //Task<IQueryable<LessonContentUP>> GetAllLessonContentUP();
        //Task<IQueryable<ResourceLinkUP>> GetAllResourceLinkUP();
        //Task<IQueryable<SubjectUP>> GetAllSubjectUP();
        //Task<IQueryable<QuizUP>> GetAllQuizUP();
        //Task<IQueryable<QuizQuestionUP>> GetAllQuizQuestionUP();
        //Task<IQueryable<QuizQuestionQuizUP>> GetAllQuizQuestionQuizUP();
        //Task<IQueryable<AnswerUP>> GetAllAnswerUP();

        Task<string> Copy(Guid idsubject);


    }
}
