using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
namespace Quanlycf.Staff
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
        public List<Product> GetFoodByCategoryID(int id)
        {
            List<Product> list = new List<Product>();

            string query = "select * from dbo.tblProduct where category_id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product food = new Product(item);
                list.Add(food);
            }

            return list;
        }

        public List<Product> GetListFood()
        {
            List<Product> list = new List<Product>();

            string query = "select * from dbo.tblProduct";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product food = new Product(item);
                list.Add(food);
            }

            return list;
        }

        

        
    }
}
