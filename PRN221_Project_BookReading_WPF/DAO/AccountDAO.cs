using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccountDAO
    {
        private PRN221_ProjectContext _context;
        private static AccountDAO _instance = null;
        public static AccountDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AccountDAO();
                }
                return _instance;
            }
        }
        private AccountDAO()
        {
            _context = new PRN221_ProjectContext();
        }
        
        public User GetAccount(string username, string password)
        {
            try
            {
                var _res = _context.Users.SingleOrDefault(a => a.UserName.Equals(username) && a.Password.Equals(password));
                return _res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public List<string> GetAllRoleName()
        {
            try
            {
                var _res = _context.Roles.Select(x => x.RoleName).ToList();
                return _res;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public List<User> GetUserBySearch(string text)
        {
            try
            {
                var _res = _context.Users.Where(u =>
                u.Address.Contains(text) ||
                u.Email.Contains(text) ||
                u.UserName.Contains(text) ||
                u.Phone.Contains(text)).ToList();
                return _res;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public List<User> GetAllAccounts()
        {
            try
            {
                var _res = _context.Users.Include(x => x.Role).Where(a => a.RoleId != 4).ToList();
                return _res;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public bool deleteAccount(int id)
        {
            try
            {
                var accountToDelete = _context.Users.SingleOrDefault(a => a.UserId == id);
                if (accountToDelete != null)
                {
                    accountToDelete.Active = false;
                    _context.Users.Update(accountToDelete);
                    _context.SaveChanges();
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public int GetRoleIdByRoleName(string roleName)
        {
            try
            {
                var role = _context.Roles.SingleOrDefault(r => r.RoleName.Equals(roleName));
                return role.RoleId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetUserIdByUsername(string username)
        {
            try
            {
                var user = _context.Users.SingleOrDefault(r => r.UserName.Equals(username));
                return user.UserId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void updateAccount(User account)
        {
            try
            {
                var accountToUpdate = _context.Users.SingleOrDefault(a => a.UserId == account.UserId);
                if (accountToUpdate != null)
                {
                    accountToUpdate.RoleId = account.RoleId;
                    _context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
