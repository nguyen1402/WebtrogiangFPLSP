namespace FPLSP.Server.Domain.Dtos.DoQuizDtos
{
    public class GetListQuestionAndScore
    {
        public GetListQuestionAndScore()
        {
            QuestionCollectionGet = new List<QuestionDto>();
        }
        public double Score { get; set; }
        public List<QuestionDto> QuestionCollectionGet { get; set; }
    }
}
