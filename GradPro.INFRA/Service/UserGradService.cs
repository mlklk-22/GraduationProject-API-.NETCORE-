using GradPro.CORE.Data;
using GradPro.CORE.Repository;
using GradPro.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradPro.INFRA.Service
{
    public class UserGradService : IUserGradService
    {
        #region Objects
        private readonly IUserGradRespoitory _UserGradRespoitory;
        #endregion

        #region Constructors
        public UserGradService(IUserGradRespoitory userGradRespoitory)
        {
            _UserGradRespoitory= userGradRespoitory;
        }
        #endregion

        #region Method
        public void CreateUser(Usergrad user)
        {
            _UserGradRespoitory.CreateUser(user);
        }

        public void DeleteUser(int UserIdd)
        {
           _UserGradRespoitory.DeleteUser(UserIdd);
        }

        public List<Usergrad> GetAllUsers()
        {
            return _UserGradRespoitory.GetAllUsers();
        }

        public Usergrad GetUserById(int UserIdd)
        {
            return _UserGradRespoitory.GetUserById(UserIdd);
        }

        public void UpdateUser(Usergrad user)
        {
            _UserGradRespoitory.UpdateUser(user);
        } 
        #endregion
    }
}
