using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TotalTransactionAmount { get; set; }
        public string CCCD { get; set; }
        public DateTime LatestTransaction {  get; set; }

        public Customer() { }

        public Customer(int id, string name, string CCCD, double totalTransactionAmount, DateTime LatestTransaction)
        {
            Id = id;
            Name = name;
            this.CCCD = CCCD;
            TotalTransactionAmount = totalTransactionAmount;
            this.LatestTransaction = LatestTransaction;
        }
    }
}
