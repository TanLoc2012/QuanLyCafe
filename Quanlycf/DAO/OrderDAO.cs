using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quanlycf.DTO;
namespace Quanlycf.DAO
{

    public class OrderDAO
    {
        private static OrderDAO instance;
        public static OrderDAO Instance
        {
            get { if (instance == null) instance = new OrderDAO(); return OrderDAO.instance; }
            private set { OrderDAO.instance = value; }

        }
        public static int OrderWidth = 70;
        public static int OrderHeight = 20;
        private OrderDAO()
        {

        }

        public List<Order> LoadOrderList()
        {
            List<Order> OrderList = new List<Order>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetOrderList");
            foreach (DataRow item in data.Rows)
            {
                Order order = new Order(item);
                OrderList.Add(order);
            }
            return OrderList;
        }

    }
}
