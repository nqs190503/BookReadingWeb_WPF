using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository
{
    public interface IAccountRespository
    {
        public User GetAccount(string username, string password);
        public List<User> GetAllAccounts();
        public List<string> GetAllRoleName();
        public List<User> GetUserBySearch(string text);
        public int GetRoleIdByRoleName(string roleName);
        public int GetUserIdByUsername(string username);
        public bool deleteAccount(int id);
        public void updateAccount(User account);
    }
}
