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
    /// Interaction logic for SelectionWindow.xaml
    /// </summary>
    public partial class SelectionWindow : Window
    {
        Handler selectionHandler = new Handler();

        public SelectionWindow()
        {
            InitializeComponent();
            this.Date_Time.Content = selectionHandler.currentDateTime();
        }


        /* 
        *   
        */
        private void View_Expenditure_Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            selectionHandler.showViewExpendituresWindow();
        }

        /* 
        *   
        */
        private void Add_Expenditure_Button_Click(object sender, RoutedEventArgs e)
        {
            selectionHandler.showAddExpenseWindow();
        }
    }
}
