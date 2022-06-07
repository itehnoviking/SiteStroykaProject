namespace stroyka.Core
{
    public interface IFeedbacksService
    {
        Task<int?> DeleteAsync(Guid modelId);
    }
}
