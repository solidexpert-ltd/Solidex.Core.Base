using System;
using System.Threading.Tasks;

namespace Solidex.Core.Base.Infrastructure
{
    public interface ICrudRepository<TEditModel, TViewModel> where TEditModel: class where TViewModel: class
    {
        Task<ResponseViewModel<TViewModel>> GetViewModelAsync(Guid modelId);
        Task<ResponseViewModel> CreateEntityAsync(string shortcut, TEditModel model);
        Task<ResponseViewModel> SaveEntityAsync(TEditModel model);
        Task<ResponseViewModel> RemoveEntityAsync(Guid entityId);
    }
}
