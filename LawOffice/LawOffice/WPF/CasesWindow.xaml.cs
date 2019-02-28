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
    /// Interaction logic for Cases.xaml
    /// </summary>
    public partial class CasesWindow : Window
    {
        LOContext db = new LOContext();
        //Method for filling DataGrids
        public void Fill()
        {
            LOContext db = new LOContext();
            var query = from Case in db.Cases
                        select Case;
            DataGrid1.DataContext = query.ToList();
        }
        //Method for filling ComboBox-a
        public void FillCombo()
        {
            var q1 = from Client in db.Clients
                     select Client.Name + " " + Client.Surname;
            ComboBoxClient.DataContext = q1.ToList();
        }
        public CasesWindow()
        {
            InitializeComponent();
            Fill();
            FillCombo();
        }
    
        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Manu win3 = new Manu();
            win3.Show();
            this.Close(); ;
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var x = from Case in db.Cases
                    where Case.Name.Contains(TextBoxSearch.Text) || Case.CaseCode.Contains(TextBoxSearch.Text)
                    select Case;

            DataGrid1.DataContext = x.ToList();
        }

        private void Button_ClickAddNew(object sender, RoutedEventArgs e)
        {
            //Validation
            if (String.IsNullOrWhiteSpace(TextBoxName.Text) || String.IsNullOrWhiteSpace(TextBoxCode.Text) || String.IsNullOrWhiteSpace(ComboBoxClient.Text))
            {
                MessageBox.Show("Fill all fields", "Wrong input");
                return;
            }
            if (!Regex.IsMatch(TextBoxName.Text, "^[a-zA-Z ]*$"))
            {
                MessageBox.Show("Name must be letters", "Wrong input");
                return;
            }

            //Select Client id
            string text = ComboBoxClient.SelectedItem as string;
            var x = from Client in db.Clients
                    where (Client.Name + " " + Client.Surname) == text
                    select Client.ClientId;
            //Adding a new Case
            var Case = new Case() { Name = TextBoxName.Text, CaseCode = TextBoxCode.Text, ClientId = x.ToList().First()};
            db.Cases.Add(Case);
            db.SaveChanges();
            MessageBox.Show("New case is added to base", "New data");
            //Set default
            TextBoxName.Clear();
            TextBoxCode.Clear();
            ComboBoxClient.SelectedIndex = -1;
            Fill();

        }

        private void Button_ClickRefresh(object sender, RoutedEventArgs e)
        {
            Fill();
            FillCombo();
        }
    }
}
