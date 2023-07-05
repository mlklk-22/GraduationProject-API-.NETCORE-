using Dapper;
using GradPro.CORE.Common;
using GradPro.CORE.Data;
using GradPro.CORE.Repository;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GradPro.INFRA.Repository
{
    public class UserGradRespoitory : IUserGradRespoitory
    {
        #region Objects
        private readonly IDbContext _dbContext;
        #endregion

        #region Constructors
        public UserGradRespoitory(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Methods
        public void CreateUser(Usergrad user)
        {
            var dynamicParam = new DynamicParameters();
            dynamicParam.Add("FullNamee", user.Fullname, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("UserNamee", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("Emaill", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("PhoneNumberr", user.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("Passwordd", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("Imagee", user.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("RoleIdd", user.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            dynamicParam.Add("USER_PROJECTT", user.UserProject, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("UserGrad_Package.CreateUser", dynamicParam, commandType: CommandType.StoredProcedure);

        }

        public void DeleteUser(int UserIdd)
        {
            DynamicParameters dynamicParam = new DynamicParameters();
            dynamicParam.Add("UserIdd", UserIdd, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("UserGrad_Package.DeleteUser", dynamicParam, commandType: CommandType.StoredProcedure);
        }

        public List<Usergrad> GetAllUsers()
        {
            var UsersList = _dbContext.Connection.Query<Usergrad>("UserGrad_Package.GetAllUsers", commandType: CommandType.StoredProcedure);
            return UsersList.ToList();
        }

        public Usergrad GetUserById(int UserIdd)
        {
            var dynamicParam = new DynamicParameters();
            dynamicParam.Add("UserIdd", UserIdd, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var GetUser = _dbContext.Connection.Query<Usergrad>("UserGrad_Package.GetUserById", dynamicParam, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return GetUser;
        }

        public void UpdateUser(Usergrad user)
        {
            var dynamicParam = new DynamicParameters();
            dynamicParam.Add("UserIdd", user.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            dynamicParam.Add("FullNamee", user.Fullname, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("UserNamee", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("Emaill", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("PhoneNumberr", user.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("Passwordd", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("Imagee", user.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            dynamicParam.Add("RoleIdd", user.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            dynamicParam.Add("USER_PROJECTT", user.UserProject, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("UserGrad_Package.UpdateUser", dynamicParam, commandType: CommandType.StoredProcedure);

        } 

        #endregion
    }
}
