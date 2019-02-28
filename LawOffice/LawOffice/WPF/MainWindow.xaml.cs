
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

namespace LawOffice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LOContext db = new LOContext();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_ClickNewUser(object sender, RoutedEventArgs e)
        {
            NewUser win2 = new NewUser();
            win2.Show();
            this.Close();
        }

        private void Button_ClickExit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_ClickLogIn(object sender, RoutedEventArgs e)
        {
            //Validation
            if (String.IsNullOrWhiteSpace(TextBoxUserName.Text) || String.IsNullOrWhiteSpace(TextBoxPassword.Password))
            {
                MessageBox.Show("Fill all fields", "Wrong input");
                return;
            }
            //Checking username and password; LogIn
            foreach (User column in db.Users)
            {
                if (column.Username == TextBoxUserName.Text)
                {
                    if (column.Password != Utility.Hash(TextBoxPassword.Password))
                    {
                        MessageBox.Show("Please insert corect username or password!", "Wrong input");
                        return;
                    }
                    var stu = from User in db.Users
                    where User.Username == TextBoxUserName.Text
                    select User.Admin;

                    Utility.UserAdmin = stu.ToList().First();

                    Manu win3 = new Manu();
                    win3.Show();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Please insert corect username or password!", "Wrong input");
            return;
               
            }
        }
    
}
