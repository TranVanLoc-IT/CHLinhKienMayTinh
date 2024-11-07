using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        private NHANVIENTableAdapter _db;
        public LoginDAL()
        {
            _db = new NHANVIENTableAdapter();   
        }
        public string Login(string userName, string password)
        {
            QueriesTableAdapter adapter = new QueriesTableAdapter();
            var nv = adapter.DangNhap(userName, password);
            if (nv != null)
            {
                return nv.ToString();
            }
            return string.Empty;
        }
        public static string GetCurrentUserId(string userName)
        {
            QueriesTableAdapter adapter = new QueriesTableAdapter();
            return adapter.LayIDNguoiDung(userName);
        }
    }
}
