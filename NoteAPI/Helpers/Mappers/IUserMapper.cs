using Entities;
using ViewModels;

namespace NoteAPI.Helpers.Mappers
{
    public interface IUserMapper
    {
        UserViewModel Map(User source);
    }
}