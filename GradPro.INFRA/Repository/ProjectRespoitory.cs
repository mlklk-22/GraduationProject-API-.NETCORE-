using Dapper;
using GradPro.CORE.Common;
using GradPro.CORE.Data;
using GradPro.CORE.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GradPro.INFRA.Repository
{
    public class ProjectRespoitory : IProjectRespository
    {
        #region Objects
        private readonly IDbContext _dbContext;
        #endregion

        #region Constructors
        public ProjectRespoitory(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Method
        public void CreateProject(Projectgrad project)
        {
            var dynamicParam = new DynamicParameters();
            dynamicParam.Add("ProjectName", project.Projectname, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("ProjectDescription", project.Projectname, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("ProjectPrice", project.Projectname, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("ProjectMajor", project.Projectname, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("ProjectPeriod", project.Projectname, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("ProjectImage", project.Projectname, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("MajorId", project.Projectname, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("ProjectGrad_Package.CreateProject", dynamicParam, commandType: CommandType.StoredProcedure);

        }

        public void DeleteProject(int projectIdd)
        {
            var dynamicParam = new DynamicParameters();
            dynamicParam.Add("projectIdd", projectIdd, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("ProjectGrad_Package.DeleteProject", dynamicParam, commandType: CommandType.StoredProcedure);
        }

        public List<Projectgrad> GetAllProjects()
        {
            var ProjectList = _dbContext.Connection.Query<Projectgrad>("ProjectGrad_Package.GetAllProjects", commandType: CommandType.StoredProcedure);
            return ProjectList.ToList();
        }

        public Projectgrad GetProjectById(int projectIdd)
        {
            var dynamicParam = new DynamicParameters();
            dynamicParam.Add("projectIdd", projectIdd, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var GetProject = _dbContext.Connection.Query<Projectgrad>("ProjectGrad_Package.GetProjectById", dynamicParam, commandType: CommandType.StoredProcedure);
            return GetProject.FirstOrDefault();
        }

        public void UpdateProject(Projectgrad project)
        {
            var dynamicParam = new DynamicParameters();
            dynamicParam.Add("projectIdd", project.Projectid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            dynamicParam.Add("ProjectName", project.Projectname, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("ProjectDescription", project.Projectname, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("ProjectPrice", project.Projectname, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("ProjectMajor", project.Projectname, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("ProjectPeriod", project.Projectname, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("ProjectImage", project.Projectname, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("MajorId", project.Projectname, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("ProjectGrad_Package.UpdateProject", dynamicParam, commandType: CommandType.StoredProcedure);

        }
        #endregion
    }
}
