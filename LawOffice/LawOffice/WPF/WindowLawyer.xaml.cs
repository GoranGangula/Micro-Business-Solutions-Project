using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for WindowLawyer.xaml
    /// </summary>
    public partial class WindowLawyer : Window
    {
        LOContext db = new LOContext();

        //Method for filling DataGrids
        public void Fill()
        {
            LOContext db = new LOContext();
            var stu = from Lawyer in db.Lawyers
                      select Lawyer;

            DataGrid1.DataContext = stu.ToList();
        }

        public WindowLawyer()
        {
            InitializeComponent();
            Fill();
        }

        private void Button_ClickAddNew(object sender, RoutedEventArgs e)
        {
            //Validation
            if (String.IsNullOrWhiteSpace(TextBoxName.Text) || String.IsNullOrWhiteSpace(TextBoxSurname.Text))
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

            //Adding a new u bazu
            var lawyer = new Lawyer() { Name = TextBoxName.Text, Surname = TextBoxSurname.Text};
            db.Lawyers.Add(lawyer);
            db.SaveChanges();
            MessageBox.Show("New lawyer is added to base","New data");
            TextBoxName.Clear();
            TextBoxSurname.Clear();
            Fill();
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Manu win3 = new Manu();
            win3.Show();
            this.Close();
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var x = from Lawyer in db.Lawyers
                    where Lawyer.Name.Contains(TextBoxSearch.Text) || Lawyer.Surname.Contains(TextBoxSearch.Text)
                    select Lawyer;

            DataGrid1.DataContext = x.ToList();
        }

        private void Button_ClickReview(object sender, RoutedEventArgs e)
        {
            if (DataGrid1.SelectedCells.Count > 0)
            {
                Lawyer da = (Lawyer)DataGrid1.SelectedItem;
                
                var stu = from Task in db.Tasks
                          where Task.UnderCase.Case.Client.Lawyer.LawyerId == da.LawyerId
                          select Task;

                SelectedTask win1 = new SelectedTask(stu.ToList());

                win1.Show();
            }
            else
            {
                MessageBox.Show("No selection", "Wrong input");
            }
        }

        private void Button_ClickRefresh(object sender, RoutedEventArgs e)
        {
            Fill();
        }
    }
}
