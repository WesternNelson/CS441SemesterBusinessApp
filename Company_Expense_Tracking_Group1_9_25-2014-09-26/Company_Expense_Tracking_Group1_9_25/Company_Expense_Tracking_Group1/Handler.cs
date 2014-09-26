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

        
    }
}
