using GradPro.CORE.Data;
using GradPro.CORE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GradPro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        #region Objects
        private readonly IProjectService _projectService;
        #endregion

        #region Constructors
        public ProjectController(IProjectService projectService) 
        {
            _projectService = projectService;
        }
        #endregion

        #region Methods

        [HttpPost]
        [Route("CreateProject")]
        public void CreateProject(Projectgrad project)
        {
            _projectService.CreateProject(project);
        }

        [HttpDelete]
        [Route("DeleteProject/projectIdd")]
        public void DeleteProject(int projectIdd)
        {
            _projectService.DeleteProject(projectIdd);
        }


        [HttpGet]
        [Route("GetAllProjects")]
        public List<Projectgrad> GetAllProjects()
        {
            return _projectService.GetAllProjects();
        }


        [HttpGet]
        [Route("GetProject/projectIdd")]
        public Projectgrad GetProjectById(int projectIdd)
        {
            return _projectService.GetProjectById(projectIdd);
        }


        [HttpPut]
        [Route("UpdateProject")]
        public void UpdateProject(Projectgrad project)
        {
            _projectService.UpdateProject(project);
        }
        #endregion
    }
}
