using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Quanlycf.Staff
{
    class OrderDetailDAO
    {
        private static OrderDetailDAO instance;

        public static OrderDetailDAO Instance
        {
            get { if (instance == null) instance = new OrderDetailDAO(); return OrderDetailDAO.instance; }
            private set { OrderDetailDAO.instance = value; }
        }
        private OrderDetailDAO() { }
       
        public List<OrderDetail> GetListBillInfo(int id)
        {
            List<OrderDetail> listBillInfo = new List<OrderDetail>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.tblOrderDetail WHERE @order_id = " + id);

            foreach (DataRow item in data.Rows)
            {
                OrderDetail info = new OrderDetail(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @order_id , @category_id , @num", new object[] { idBill, idFood, count });
        }
    }


}

