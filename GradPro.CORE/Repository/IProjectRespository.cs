using GradPro.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradPro.CORE.Repository
{
    public interface IProjectRespository
    {
        void CreateProject(Projectgrad project);
        void UpdateProject(Projectgrad project);
        List<Projectgrad> GetAllProjects();
        Projectgrad GetProjectById(int projectIdd);
        void DeleteProject(int projectIdd);
    }
}
