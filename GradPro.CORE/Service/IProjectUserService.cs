using GradPro.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradPro.CORE.Service
{
    public interface IProjectUserService
    {
        void CreateProjectIUser(UserProject userProject);
        void UpdateProjectIUser(UserProject userProject);
        List<UserProject> GetAllProjectIUser();
        UserProject GetProjectIUserById(int USER_PROJECTT);
        void DeleteProjectIUser(int USER_PROJECTT);
    }
}
