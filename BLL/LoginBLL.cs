using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        private LoginDAL _loginDAL;
        public LoginBLL()
        {
            this._loginDAL = new LoginDAL();
        }
        public string Login(string userName, string password)
        {
            return _loginDAL.Login(userName, password);
        }
        public static string GetCurrentUserId(string userName)
        {
            return LoginDAL.GetCurrentUserId(userName);
        }
    }
}
