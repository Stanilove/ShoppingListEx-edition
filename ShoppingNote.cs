using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEX
{
    class ShoppingNote
    {
        public String name { get; private set; }
        public String comment { get; private set; }
        public double spentamount { get; private set; }
        public DateTime dateofpurchase { get; private set; }
        public long number { get; private set; }

        public ShoppingNote(String name, String comment, double spentamount, DateTime dateofpurchase, long number)
        {
            this.name = name;
            this.comment = comment;
            this.spentamount = spentamount;
            this.dateofpurchase = dateofpurchase;
            this.number = number;
        }

        public string toString()
        {
            return
                 $"Number in list: {this.number},  " + 
                 $"Name: {this.name},  " + 
                 $"Comment: {this.comment},  " + 
                 $"Amount of credit spent: {this.spentamount},  " + 
                 $"Date of purchase: {this.dateofpurchase.ToString("dd/MM/yyyy")}" ;
        }





    }
}