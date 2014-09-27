using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows;
using System.Xml.Linq;
using System.Xml.Serialization;



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
               return null;
           }
            
        }

        /*
         * This function will return True if the User ID and Password match up from the data base
         * 
         */
        public bool Authenticate(String UserID, String UserPassword)
        {
            User user = new User();
            user = this.GetUser(UserID);
            if ((UserID == user.User_ID) && (UserPassword == user.User_Password))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error: Not a valid user name or pass word");
                return false;
            }
        }

        /*
         * This function will grab all the User information attached to that UserId 
         * 
         */
        public User GetUser(String UserID)
        {
            User user = new User();

            XElement elem = loadXMLforuser();
            user.User_ID = elem.Element("User").Element("login").Attribute("username").Value;
            user.User_Password = elem.Element("User").Element("login").Attribute("password").Value;
            Console.WriteLine("the username is " + user.User_ID + "\nAnd the password for this admin is " + user.User_Password);

            return user;
        }

        public XElement loadXMLforuser()
        {
            string settingsDirectory = Environment.CurrentDirectory;
            string fileName = "users-xml.xml";
            string settingsPath = Path.Combine(settingsDirectory, fileName);
            Console.WriteLine("the file path for the xml is" + settingsPath);
            XElement xmlelement = XElement.Load(settingsPath);
            Console.WriteLine("XML file loaded");

            return xmlelement;
        }
        /*
         *This will create the Admin right, Folder, and start up userXML
         * 
         */
        public void startUpWriteXMLForAdminUser()
        {

            XElement adminXML = 
                new XElement("Users",
                        new XElement( "User",  new XAttribute("admin-rights", "yes"),
                            new XElement("login", new XAttribute("username", "Admin" ),
                                new XAttribute("password", "password" ) ) ) );

            XDocument AdminRights = new XDocument( adminXML);

            string filePath = Environment.CurrentDirectory;
            AdminRights.Save(Path.Combine( filePath , "users-XML.xml" ));
                
                
                
                
            
        }

        public bool checkUserXML()
        {
            string filePath = Environment.CurrentDirectory;
            if(File.Exists(Path.Combine( filePath , "users-XML.xml" )))
            {
                return true;

            }
            else
            {
                return false;
            }
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

       /* public static XElement ToXElement<T>(this object obj)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (TextWriter streamWriter = new StreamWriter(memoryStream))
                {
                    var xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, obj);
                    return XElement.Parse(Encoding.ASCII.GetString(memoryStream.ToArray()));
                }
            }
        }

        public static T FromXElement<T>(this XElement xElement)
        {
            using (var memoryStream = new MemoryStream(Encoding.ASCII.GetBytes(xElement.ToString())))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(memoryStream);
            }
        }*/
    
    
    }
}
