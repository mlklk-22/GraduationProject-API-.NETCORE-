using GradPro.CORE.Data;
using GradPro.CORE.Repository;
using GradPro.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradPro.INFRA.Service
{
    public class ProjectService : IProjectService
    {
        #region Objects
        private readonly IProjectRespository _projectRespository;
        #endregion

        #region Constructor
        public ProjectService(IProjectRespository projectRespository) 
        {
            _projectRespository = projectRespository;
        }
        #endregion

        #region Methods
        public void CreateProject(Projectgrad project)
        {
            _projectRespository.CreateProject(project);
        }

        public void DeleteProject(int projectIdd)
        {
            _projectRespository.DeleteProject(projectIdd);
        }

        public List<Projectgrad> GetAllProjects()
        {
            return _projectRespository.GetAllProjects();
        }

        public Projectgrad GetProjectById(int projectIdd)
        {
            return _projectRespository.GetProjectById(projectIdd);
        }

        public void UpdateProject(Projectgrad project)
        {
            _projectRespository.UpdateProject(project);
        }
        #endregion
    }
}
