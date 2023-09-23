using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CocoaLib.DbModels
{
    /// <summary>
    /// 用于大部分验证
    /// </summary>
    interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);
        void Add(LoginWpfUsersInfo user);
        void Edit(LoginWpfUsersInfo users);
        void DeleteById(int id);
        LoginWpfUsersInfo GetById(int id);
        LoginWpfUsersInfo GetByUsername(string username);
        IEnumerable<LoginWpfUsersInfo> GetAll();
    }
}
