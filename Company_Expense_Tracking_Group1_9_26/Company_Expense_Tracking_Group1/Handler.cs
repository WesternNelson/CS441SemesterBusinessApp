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
    class Handler
    {
        Data_Access Da = new Data_Access(); 
        public Handler()
        {

        }

        public string currentDateTime()
        {
            string datetime = DateTime.Now.ToString("M/d/yyyy h:mm tt", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            return datetime;
        }

        public User signInHandler(string username, string password)
        {
             User loginUser = Da.SignIn(username, password);
             return loginUser;
        }

        public void showAdminSelectionWindow()
        {
            AdminSelectionWindow adminWindow = new AdminSelectionWindow();
            adminWindow.Show();
        }

        public void showSelectionWindow()
        {
            SelectionWindow selectWindow = new SelectionWindow();
            selectWindow.Show();
        }

        public void showAddExpenseWindow()
        {
            AddExpenseWindow expenseWindow = new AddExpenseWindow();
            expenseWindow.Show();
        }

        public void showAddUserWindow()
        {
            AddUserWindow addUserWindow = new AddUserWindow();
            addUserWindow.Show();
        }

        public void showViewActivitiesWindow()
        {
            ViewUserActivities viewUserActsWindow = new ViewUserActivities();
            viewUserActsWindow.Show();
        }

        public void showViewExpendituresWindow()
        {
            ViewExpenditures viewExpendsWindow = new ViewExpenditures();
            viewExpendsWindow.Show();
        }

        public void writeExpenseXml()
        {
            //Da.WriteXML(); create this
        }

        public XElement readXML()
        {
            XElement xelement;
            return xelement = Da.loadXMLforuser();
        }


        //This will deal with the logic if XML files are present or not
        public XElement appStartUp()
        {
            if (!Da.checkUserXML())
            {
                Da.startUpWriteXMLForAdminUser();
            }
            XElement loadedUserXML = Da.loadXMLforuser();
            Console.WriteLine("AppStartUP ok");
            return loadedUserXML;
        }

        public List<string> initializeUserList(XElement Xelem)
        {
            if (Xelem == null)
                Console.WriteLine("there is nothing in the XElem");

            List<string> UserList = new List<string>();
            Console.WriteLine("initiallistcreated");
            string nameOfUser = Xelem.Element("User").Element("login").Attribute("username").Value;
          
            Console.WriteLine("the name of the user is" + nameOfUser);
            UserList.Add(nameOfUser);
            return UserList;
        }



        

    }
}
