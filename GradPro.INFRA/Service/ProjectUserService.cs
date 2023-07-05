using GradPro.CORE.Data;
using GradPro.CORE.Repository;
using GradPro.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradPro.INFRA.Service
{
    public class ProjectUserService : IProjectUserService
    {
        #region Objects
        readonly private IProjectUserRepository _projectUserRepository;
        #endregion

        #region Constructors
        public ProjectUserService(IProjectUserRepository projectUserRepository) 
        {
            _projectUserRepository = projectUserRepository;
        }
        #endregion

        #region Methods
        public void CreateProjectIUser(UserProject userProject)
        {
            _projectUserRepository.CreateProjectIUser(userProject);
        }

        public void DeleteProjectIUser(int USER_PROJECTT)
        {
            _projectUserRepository.DeleteProjectIUser(USER_PROJECTT);
        }

        public List<UserProject> GetAllProjectIUser()
        {
            return _projectUserRepository.GetAllProjectIUser();
        }

        public UserProject GetProjectIUserById(int USER_PROJECTT)
        {
            return _projectUserRepository.GetProjectIUserById(USER_PROJECTT);
        }

        public void UpdateProjectIUser(UserProject userProject)
        {
            _projectUserRepository.UpdateProjectIUser(userProject);
        } 
        #endregion
    }
}
