using DAL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using NoteAPI.DataHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ViewModels;

namespace NoteAPI.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersDataHelper _usersDataHelper;

        public UsersController(IUsersDataHelper usersDataHelper)
        {
            _usersDataHelper = usersDataHelper;
        }

        [HttpGet]
        [Route("User/{id}")]
        public async Task<IActionResult> GetUser([Required] Guid id, CancellationToken cancellationToken)
            => Ok(await _usersDataHelper.GetUserViewModel(id, cancellationToken));
    }
}
