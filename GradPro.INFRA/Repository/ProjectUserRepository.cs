using Dapper;
using GradPro.CORE.Common;
using GradPro.CORE.Data;
using GradPro.CORE.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace GradPro.INFRA.Repository
{
    public class ProjectUserRepository : IProjectUserRepository
    {
        #region Objects
        private readonly IDbContext _dbContext;
        #endregion

        #region Constructors
        public ProjectUserRepository(IDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Method
        public void CreateProjectIUser(UserProject userProject)
        {
            var dynamicParam = new DynamicParameters();
            dynamicParam.Add("UserId", userProject.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            dynamicParam.Add("ProjectId", userProject.Projectid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("ProjectIUser_Package.CreateProjectIUser", dynamicParam, commandType: CommandType.StoredProcedure);

        }
        public void UpdateProjectIUser(UserProject userProject)
        {
            var dynamicParam = new DynamicParameters();
            dynamicParam.Add("USER_PROJECTT", userProject.UserProject1, dbType: DbType.Int32, direction: ParameterDirection.Input);
            dynamicParam.Add("UserId", userProject.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            dynamicParam.Add("ProjectId", userProject.Projectid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("ProjectIUser_Package.UpdateProjectIUser", dynamicParam, commandType: CommandType.StoredProcedure);
        }
        public List<UserProject> GetAllProjectIUser()
        {
            var ProjectUserList = _dbContext.Connection.Query<UserProject>("ProjectIUser_Package.GetAllProjectIUser", commandType: CommandType.StoredProcedure);
            return ProjectUserList.ToList();
        }
        public UserProject GetProjectIUserById(int USER_PROJECTT)
        {
            var dynamicParam = new DynamicParameters();
            dynamicParam.Add("USER_PROJECTT", USER_PROJECTT, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var GetProjectUser = _dbContext.Connection.Query<UserProject>("ProjectIUser_Package.GetProjectIUserById", dynamicParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return GetProjectUser;
        }
        public void DeleteProjectIUser(int USER_PROJECTT)
        {
            var dynamicParam = new DynamicParameters();
            dynamicParam.Add("USER_PROJECTT", USER_PROJECTT, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("ProjectIUser_Package.DeleteProjectIUser", dynamicParam, commandType: CommandType.StoredProcedure);
        }
        #endregion


    }
}
