using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycf.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }

        }
        private ProductDAO()
        {

        }
    }
}
