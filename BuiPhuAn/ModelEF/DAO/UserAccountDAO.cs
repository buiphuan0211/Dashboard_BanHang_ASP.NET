using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DAO
{
    public class UserAccountDAO
    {
        private PhuAnContext db = new PhuAnContext();

        // trả về một mẫu tin Object
        public UserAccount getRow(String username)
        {
            var row = db.UserAccounts.Where(m => m.UserName == username)
                .FirstOrDefault();
            return row;
        }       
    }
}
