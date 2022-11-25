using Microsoft.VisualBasic.ApplicationServices;
using SipsisDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SipsisBLL.Repsitory.Entity
{
    public class UserRepository : Base.BaseRepository<user>
    {
        public bool logincontrol(string username, string pass)
        {
            bool rtn = table.Any(x=> x.UserName == username && x.Password == pass);
            if(rtn == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public user FindUserName(string username)
        {
            return table.FirstOrDefault(x => x.UserName == username);
        }
    }
}
