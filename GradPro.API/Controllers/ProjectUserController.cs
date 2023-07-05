using GradPro.CORE.Data;
using GradPro.CORE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GradPro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectUserController : ControllerBase
    {
        #region objects
        readonly private IProjectUserService _projectUserService;
        #endregion

        #region Constructor
        public ProjectUserController(IProjectUserService projectUserService) 
        {
            _projectUserService = projectUserService;
        }
        #endregion

        #region Methods

        [HttpPost]
        [Route("CreateProjectIUser")]
        public void CreateProjectIUser(UserProject userProject)
        {
            _projectUserService.CreateProjectIUser(userProject);
        }

        [HttpDelete]
        [Route("DeleteProjectIUser/USER_PROJECTT")]
        public void DeleteProjectIUser(int USER_PROJECTT)
        {
            _projectUserService.DeleteProjectIUser(USER_PROJECTT);
        }

        [HttpGet]
        [Route("GetAllProjectIUser")]
        public List<UserProject> GetAllProjectIUser()
        {
            return _projectUserService.GetAllProjectIUser();
        }

        [HttpGet]
        [Route("GetProjectIUser/USER_PROJECTT")]
        public UserProject GetProjectIUserById(int USER_PROJECTT)
        {
            return _projectUserService.GetProjectIUserById(USER_PROJECTT);
        }

        [HttpPut]
        [Route("UpdateProjectIUser")]
        public void UpdateProjectIUser(UserProject userProject)
        {
            _projectUserService.UpdateProjectIUser(userProject);
        }
        #endregion
    }
}
