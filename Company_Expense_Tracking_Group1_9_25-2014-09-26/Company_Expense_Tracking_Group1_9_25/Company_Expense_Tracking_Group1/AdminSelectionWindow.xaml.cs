using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Company_Expense_Tracking_Group1
{
    /// <summary>
    /// Interaction logic for AdminSelectionWindow.xaml
    /// </summary>
    public partial class AdminSelectionWindow : Window
    {
        Handler adminSelectionHandler = new Handler();
        public AdminSelectionWindow()
        {
            InitializeComponent();
            Date_Time_Label.Content = adminSelectionHandler.currentDateTime();
        }

        /* 
        *   
        */
        private void Add_Expenditure_Button_Click(object sender, RoutedEventArgs e)
        {
            adminSelectionHandler.showAddExpenseWindow();
        }



        /* 
        *   
        */
        private void View_Expenses_Button_Click(object sender, RoutedEventArgs e)
        {
            adminSelectionHandler.showViewExpendituresWindow();
        }



        /* 
        *   
        */
        private void View_User_Activity_Button_Click(object sender, RoutedEventArgs e)
        {
            adminSelectionHandler.showViewActivitiesWindow();
        }



        /* 
        *   
        */
        private void Add_User_Button_Click(object sender, RoutedEventArgs e)
        {
            adminSelectionHandler.showAddUserWindow();
        }
    }
}
