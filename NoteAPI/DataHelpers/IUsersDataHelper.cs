using System;
using System.Threading;
using System.Threading.Tasks;
using ViewModels;

namespace NoteAPI.DataHelpers
{
    public interface IUsersDataHelper
    {
        Task<UserViewModel> GetUserViewModel(Guid id, CancellationToken token);
    }
}