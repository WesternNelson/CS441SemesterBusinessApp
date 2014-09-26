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
    class Data_Access
    {
        /*
         * This function will retrun a User Class if the UserId & Password are complete
         * 
         */
        public User SignIn(String UserID, String UserPassword)
        {
            User user = new User();

           if(this.Authenticate(UserID, UserPassword) == true)
           {
               return user  = this.GetUser(UserID);
           }
           else
           {
               MessageBox.Show("Error: Not a valid user name or pass word");
               return user;
           }
            
        }

        /*
         * This function will return True if the User ID and Password match up from the data base
         * 
         */
        public bool Authenticate(String UserID, String UserPassword)
        {

            //add authentication logic here
            return true;
        }

        /*
         * This function will grab all the User information attached to that UserId 
         * 
         */
        public User GetUser(String UserID)
        {
            User user = new User();

            XElement elem = readXMLforuser();
            user.User_ID = elem.Attribute("username").Value;

            return user;
        }

        public XElement readXMLforuser()
        {
            string filename = Path.GetFullPath(@"\AppXMLs\login.xml");
            //string filepath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
            XElement xmlelement = XElement.Load(filename);
            Console.WriteLine("XML file loaded");

            return xmlelement;
        }

       /*
        * This function will take an expense class and place it into the XML
        * 
        */
        //public void AddExpense(Expense newExpense);

        /*
         * This function will grab a collections of expenses that meet the Category and date
         * 
         */
        //public ICollection<Expense> GetExpense(String Category, String Date);
    }
}
