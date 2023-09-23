using CocoaLib.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CocoaLib.ViewModel;

namespace CocoaLib.Repositories
{
    class UserRepository : RepositoryBase, IUserRepository
    {
        public RepositoryBase Repo { get; set; }

        public void Add(LoginWpfUsersInfo user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 验证登录用户是否存在或合法
        /// </summary>
        /// <param name="credential"></param>
        /// <returns>返回bool</returns>
        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUsr = false;
            using (var context = new QbotContext())
            {
                LoginWpfUsersInfo userInfo = null;
                try
                {
                    userInfo = context.LoginWpfUsersInfos
                        .Single(b => b.Username == credential.UserName && b.Password == credential.Password);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                validUsr = userInfo.Username == credential.UserName ? true : false;
            }
            return validUsr;
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(LoginWpfUsersInfo users)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoginWpfUsersInfo> GetAll()
        {
            throw new NotImplementedException();
        }

        public LoginWpfUsersInfo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public LoginWpfUsersInfo GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        bool IUserRepository.AuthenticateUser(NetworkCredential credential)
        {
            throw new NotImplementedException();
        }
    }
}
