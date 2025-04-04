
using BussinessObject.Models;
using DAO;
using Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository
{
    public class AccountRespository : IAccountRespository
    {
        public User GetAccount(string username, string password) => AccountDAO.Instance.GetAccount(username, password);
        public List<User> GetAllAccounts() => AccountDAO.Instance.GetAllAccounts();
        public List<string> GetAllRoleName() => AccountDAO.Instance.GetAllRoleName();
        public List<User> GetUserBySearch(string text) => AccountDAO.Instance.GetUserBySearch(text);
        public int GetRoleIdByRoleName(string roleName) => AccountDAO.Instance.GetRoleIdByRoleName(roleName);
        public int GetUserIdByUsername(string username) => AccountDAO.Instance.GetUserIdByUsername(username);
        public bool deleteAccount(int id) => AccountDAO.Instance.deleteAccount(id);
        public void updateAccount(User account) => AccountDAO.Instance.updateAccount(account);

        
    }
}
