using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DBAccess
{
    public class DataAccess
    {
        private Models.HospitalDBEntities db = new Models.HospitalDBEntities();

        public Models.Login LoginValidation(string UserName, string Password)
        {
            var tempUser = db.Logins
                  .Where(a => a.UserName != null)
                  .Where(a => a.Password != null)
                  .Where(a => a.UserName.Trim().ToLower() == UserName.ToLower())
                  .Where(a => a.Password == Password.ToLower())
                  .First();
            return tempUser;
        }

    }    
}
