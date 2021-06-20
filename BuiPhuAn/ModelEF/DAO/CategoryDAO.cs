using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DAO
{
    public class CategoryDAO
    {
        PhuAnContext db = null;
        public CategoryDAO()
        {
            db = new PhuAnContext();
        }

        public List<Category> ListCategory()
        {
            return db.Categories.ToList();
        }

    }
}
