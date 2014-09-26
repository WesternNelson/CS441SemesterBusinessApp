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
    /// Interaction logic for AddExpenseWindow.xaml
    /// </summary>
    public partial class AddExpenseWindow : Window
    {
        Handler addExpenseHandler = new Handler();
        public AddExpenseWindow()
        {
            InitializeComponent();
            this.Date_Time.Content = addExpenseHandler.currentDateTime();
        }

        private void Add_Expense_Button_Click(object sender, RoutedEventArgs e)
        {
            addExpenseHandler.writeExpenseXml();
        }

        private void Veiw_Expense_Button_Click(object sender, RoutedEventArgs e)
        {
            addExpenseHandler.showViewExpendituresWindow();
        }
    }
}
