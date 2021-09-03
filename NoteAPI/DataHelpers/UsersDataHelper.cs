using DAL;
using Entities;
using NoteAPI.Helpers.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ViewModels;

namespace NoteAPI.DataHelpers
{
    public class UsersDataHelper : IUsersDataHelper
    {
        private readonly IRepository<User> _userRepository;
        private readonly IUserMapper _userMapper;

        public UsersDataHelper(IRepository<User> userRepository, IUserMapper userMapper)
        {
            _userRepository = userRepository;
            _userMapper = userMapper;
        }

        public async Task<UserViewModel> GetUserViewModel(Guid id, CancellationToken token)
        {
            var user = await _userRepository.GetAsync(id, token);

            return user != null
                ? _userMapper.Map(user)
                : throw new Exception(); // TODO: add validation exception
        }
    }
}
