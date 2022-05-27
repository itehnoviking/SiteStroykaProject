namespace stroyka.Models
{
    public interface IFeedbackRepository
    {
        IQueryable<Feedback> Feedbacks { get; }
        void SaveFeedback(Feedback f);
    }
}
