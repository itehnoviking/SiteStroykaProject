using stroyka.Core;

namespace stroyka.Domain
{
    public class FeedbacksServices : IFeedbacksService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FeedbacksServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int?> DeleteAsync(Guid modelId)
        {
            try
            {
                if (await _unitOfWork.Feedbacks.GetById(modelId) != null)
                {
                    await _unitOfWork.Feedbacks.Remove(modelId);
                    return await _unitOfWork.Commit();
                }

                else
                {
                    return null;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
