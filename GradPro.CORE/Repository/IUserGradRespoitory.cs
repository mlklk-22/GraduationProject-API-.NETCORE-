using GradPro.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradPro.CORE.Repository
{
    public interface IUserGradRespoitory
    {
        void CreateUser(Usergrad user);
        void UpdateUser(Usergrad user);
        List<Usergrad> GetAllUsers();
        Usergrad GetUserById(int UserIdd);
        void DeleteUser(int UserIdd);
    }
}
