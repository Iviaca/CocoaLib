using CocoaLib.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
        public async Task<bool> AuthenticateUser(NetworkCredential credential)
        {

            bool validUsr =false;
            await using (var conn = await GetConnecton().OpenConnectionAsync())
            {

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
