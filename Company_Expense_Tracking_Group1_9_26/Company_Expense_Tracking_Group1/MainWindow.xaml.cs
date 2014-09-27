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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Windows;
using System.Xml.Linq;
using System.Xml.Serialization;

//using System.Windows.Forms.DataVisualization;


namespace Company_Expense_Tracking_Group1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User mainWindowUser = new User();
        AdminSelectionWindow adminWindow = new AdminSelectionWindow();
        SelectionWindow selectWindow = new SelectionWindow();

        // list for all UserNames (used in 'browse' area)
        private List<string> UserNameList = new List<string>();
       
        Handler mainWindowHandler = new Handler();
        public List<string> userNameList = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            UserName_AutoCompelte();
            this.Date_Time.Content = mainWindowHandler.currentDateTime();


            XElement userXMLMain = mainWindowHandler.appStartUp();
            Console.WriteLine("userxmlmainloaded");
            userNameList = mainWindowHandler.initializeUserList( userXMLMain);
            Console.WriteLine("userlistloaded");
            populateComboBox(userNameList);
            Console.WriteLine("comboBoxloaded");
            //TEMPORARY

        }

        /**
        * Sets UserNameList as the sourse for auto complete W/ UserName_TextBox
       */
        private void UserName_AutoCompelte()
        {
             
   
            foreach (string s in UserNameList)
            {
                //this.UserName_ComboBox.AutoCompleteCustomSource.Add(s);///NEEDS FIXING
                                                                      ///
            }
        }




        /* 
        *   
        */
        private void Sign_In_Button_Click(object sender, RoutedEventArgs e)
        {
            if (UserName_ComboBox.SelectedItem == null)
            {

                UserLogIn_Label.Content = "Username not selected";
            }
            else
            {
                mainWindowUser = mainWindowHandler.signInHandler(UserName_ComboBox.SelectedItem.ToString(), Password_TextBox.Text);


                //if (mainWindowUser.Authentication_Rights == true)
                //{
                //    if (mainWindowUser.Admin_Rights == true)
                //    {
                        mainWindowHandler.showAdminSelectionWindow();
                        //userforadminselectwindow(mainWindowUser);
                    //}
                    //else
                    //{
                    //    mainWindowHandler.showSelectionWindow();
                    //}

                    this.Hide();
                //}
                //else
                //{
                //    // MessageBox.Show("Error for some reason you don't have Authentication rights");
                //}
            }
        }

        private void UserName_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //UserName_ComboBox.Items = userNameList;
        }

        private void Password_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //This will load in the elements for the combo box
        public void populateComboBox(List<string> userList )
        {
            string entry = userList[0];
            UserName_ComboBox.Items.Add(entry);

        }

       



    }
}
