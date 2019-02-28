using System;
using System.Collections.Generic;
using System.Data;
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

namespace LawOffice
{
    /// <summary>
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        LOContext db = new LOContext();

        public NewUser()
        {
            InitializeComponent();
            
        }


        private void Button_ClickCanselUser(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void Button_ClickCreateUser(object sender, RoutedEventArgs e)
        {
            //Validation
            if (String.IsNullOrWhiteSpace(TextBoxNewUsername.Text) || String.IsNullOrWhiteSpace(TextBoxNewPassword.Password))
            {
                MessageBox.Show("Fill all fields", "Wrong input");
                return;
            }

            //Check username
            foreach (User column in db.Users)
            {
                if(column.Username == TextBoxNewUsername.Text)
                {
                    MessageBox.Show("This user already exist", "Wrong input");
                    return;
                }
            }
            //Check password
            if (TextBoxNewPassword.Password != TextBoxNewRepeatPassword.Password)
            {
                MessageBox.Show("Please insert match password", "Wrong input");
            }
            else
            {
                //Insert new user
                var user = new User() { Username = TextBoxNewUsername.Text, Password = Utility.Hash(TextBoxNewPassword.Password), Admin = false};
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Welcome  " + TextBoxNewUsername.Text, "New user is added");
                TextBoxNewUsername.Clear();
                TextBoxNewPassword.Clear();
                TextBoxNewRepeatPassword.Clear();
            }
            
        }
    }
}
