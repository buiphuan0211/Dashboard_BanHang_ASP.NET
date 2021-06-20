using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DAO
{
    public class ProductDAO
    {
        PhuAnContext db = null;
        public ProductDAO()
        {
            db = new PhuAnContext();
        }

        public List<Product> ListProduct()
        {
            return db.Products.ToList();
        }


    }
}
