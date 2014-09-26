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
    class User
    {
        public String User_ID { get; set; }

        public String User_LastName { get; set; }

        public String User_FirstName { get; set; }

        public String User_Email { get; set; }

        public String User_Password { get; set; }

        public String Last_Login { get; set; }

        public bool Authentication_Rights { get; set; }

        public bool Admin_Rights { get; set; }

    }
}
