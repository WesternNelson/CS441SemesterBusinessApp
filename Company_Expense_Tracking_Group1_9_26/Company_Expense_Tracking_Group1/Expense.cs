using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows;
using System.Xml.Linq;

namespace Company_Expense_Tracking_Group1
{
    class Expense
    {

       /*
        * This String Denotes the User who created the expense
        * 
        */
        public String CreatedBy { get; set; }

        /*
         * This String holds the type of expense it is
         * 
         */
        public String Category { get; set; }

        /*
         * This String holds the Date the expense was made
         * 
         */
        public String Date { get; set; }

        /*
         * This will hold the amount of the expense that the user inputs, either money or mileage
         * 
         */
        public decimal Amount { get; set; }




    }
}
