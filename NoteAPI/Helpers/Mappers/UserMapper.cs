using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels;

namespace NoteAPI.Helpers.Mappers
{
    // TODO - reimplement interfaces
    public class UserMapper : Mapper<User, UserViewModel>, IUserMapper
    {
        public override UserViewModel Map(User source)
            => new()
            {
                Email = source.Email,
                UserName = source.UserName
            };
    }
}
