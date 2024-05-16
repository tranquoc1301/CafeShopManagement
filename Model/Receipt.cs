using CafeShopManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Receipt
    {
        public string ID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public double TotalAmount { get; set; }
        public DateTime TransactionDate { get; set; }

        public Receipt() { }
        

        public Receipt(string iD, int customerID, int userID, double totalAmount, DateTime transactionDate)
        {
            ID = iD;
            CustomerID = customerID;
            UserID = userID;
            TotalAmount = totalAmount;
            TransactionDate = transactionDate;
        }
    }
}
