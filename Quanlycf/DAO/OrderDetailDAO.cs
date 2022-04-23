using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quanlycf.DTO;
namespace Quanlycf.DAO
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
       
        }


}

