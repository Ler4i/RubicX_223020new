using Microsoft.AspNetCore.Mvc;
using RubicX_223020new.Core.Models;
using RubicX_223020new.DataAccess.Core.Interfaces.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RubicX_223020new.BusinessLogic.Core.Interfaces;
using RubicX_223020new.BusinessLogic.Core.Models;
using AutoMapper;

namespace RubicX_223020new.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class UserController : ControllerBase 
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService)
        {
            _userService = userService;
            _mapper = _mapper;
        }

       [HttpPost("registration")]
        public async Task<ActionResult<UserInformationDto>> Register(UserIdentityDto userIdentityDto)//ActionResult - ответ на HttpPost
        {
            UserInformationBlo userInformationBlo = await _userService.RegisterWithPhone(userIdentityDto.NumberPrefix, userIdentityDto.Number, userIdentityDto.Password);

            return await ConvertToUserInformationAsync(userInformationBlo);
        }

        private async Task<UserInformationDto> ConvertToUserInformationAsync(UserInformationBlo userInformationBlo)
        {
            if (userInformationBlo == null) throw new ArgumentNullException(nameof(userInformationBlo));

            UserInformationDto userInformationDto = _mapper.Map<UserInformationDto>(userInformationBlo);

            return userInformationDto;

        }
    }
}
