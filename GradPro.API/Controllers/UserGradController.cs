using GradPro.CORE.Data;
using GradPro.CORE.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GradPro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGradController : ControllerBase
    {
        #region Objects
        readonly private IUserGradService _userGradService;
        #endregion

        #region Constructors
        public UserGradController(IUserGradService userGradService)
        { 
            _userGradService = userGradService;
        }
        #endregion

        #region Method

        [HttpPost]
        [Route("CreateUser")]
        public void CreateUser(Usergrad user)
        {
            _userGradService.CreateUser(user);
        }

        [HttpDelete]
        [Route("DeleteUser/UserIdd")]
        public void DeleteUser(int UserIdd)
        {
            _userGradService.DeleteUser(UserIdd);
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public List<Usergrad> GetAllUsers()
        {
            return _userGradService.GetAllUsers();
        }

        [HttpGet]
        [Route("GetUser/UserIdd")]
        public Usergrad GetUserById(int UserIdd)
        {
            return _userGradService.GetUserById(UserIdd);
        }

        [HttpPut]
        [Route("UpdateUser")]
        public void UpdateUser(Usergrad user)
        {
            _userGradService.UpdateUser(user);
        }
        #endregion
    }
}
