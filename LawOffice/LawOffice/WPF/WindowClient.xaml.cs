using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for WindowClient.xaml
    /// </summary>
    public partial class WindowClient : Window
    {
        LOContext db = new LOContext();

        //Method for filling DataGrids
        public void Fill()
        {
            LOContext db = new LOContext();
            var query = from Client in db.Clients
                     select Client;
            DataGrid1.DataContext = query.ToList();
        }

        //Method for filling ComboBox-a
        public void FillCombo()
        { 
        var q1 = from Lawyer in db.Lawyers
                 select Lawyer.Name + " " + Lawyer.Surname;
            ComboBoxLawyer.DataContext = q1.ToList();
        }

        public WindowClient()
        {
            InitializeComponent();
            Fill();
            FillCombo();

        }

        private void Button_ClickAddNew(object sender, RoutedEventArgs e)
        {
            //Validation
            if (String.IsNullOrWhiteSpace(TextBoxName.Text) || String.IsNullOrWhiteSpace(TextBoxSurname.Text) || String.IsNullOrWhiteSpace(ComboBoxLawyer.Text))
            {
                MessageBox.Show("Fill all fields", "Wrong input");
                return;
            }
            if (!Regex.IsMatch(TextBoxName.Text, "^[a-zA-Z]*$"))
            {
                MessageBox.Show("Name must be letters", "Wrong input");
                return;
            }
            if (!Regex.IsMatch(TextBoxSurname.Text, "^[a-zA-Z]*$"))
            {
                MessageBox.Show("Surname must be letters", "Wrong input");
                return;
            }
            //Adding a new Client
            string text = ComboBoxLawyer.SelectedItem as string;
            var x = from Lawyer in db.Lawyers
                    where (Lawyer.Name + " " + Lawyer.Surname) == text
                    select Lawyer.LawyerId;

            var Client = new Client() { Name = TextBoxName.Text, Surname = TextBoxSurname.Text, LawyerId = x.ToList().First()};
            db.Clients.Add(Client);
            db.SaveChanges();
            MessageBox.Show("New client is added to base","New data");
            TextBoxName.Clear();
            TextBoxSurname.Clear();
            ComboBoxLawyer.SelectedIndex = -1;
            Fill();
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Manu win3 = new Manu();
            win3.Show();
            this.Close(); ;
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var x = from Client in db.Clients
                    where Client.Name.Contains(TextBoxSearch.Text) || Client.Surname.Contains(TextBoxSearch.Text)
                    select Client;

            DataGrid1.DataContext = x.ToList();
        }

        private void Button_ClickReview(object sender, RoutedEventArgs e)
        {
            if (DataGrid1.SelectedCells.Count > 0)
            {
                Client da = (Client)DataGrid1.SelectedItem;

                var stu = from Task in db.Tasks
                          where Task.UnderCase.Case.Client.ClientId == da.ClientId
                          select Task;

                SelectedTask win1 = new SelectedTask(stu.ToList());

                win1.Show();
            }
            else
            {
                MessageBox.Show("No selection", "Eror");
            }
        }

        private void Button_ClickRefresh(object sender, RoutedEventArgs e)
        {
            Fill();
            FillCombo();
        }
    }
}
