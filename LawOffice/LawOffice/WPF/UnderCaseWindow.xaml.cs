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
    /// Interaction logic for UnderCaseWindow.xaml
    /// </summary>
    public partial class UnderCaseWindow : Window
    {
        LOContext db = new LOContext();
        //Method for filling DataGrids
        public void Fill()
        {
            LOContext db = new LOContext();
            var query = from UnderCase in db.UnderCases
                        select UnderCase;
            DataGrid1.DataContext = query.ToList();
        }

        //Method for filling ComboBox-a
        public void FillCombo()
        { 
        var q1 = from Case in db.Cases
                 select Case.Name + " " + Case.CaseCode;
        ComboBoxCase.DataContext = q1.ToList();
        }

        public UnderCaseWindow()
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

        private void Button_ClickAddNew(object sender, RoutedEventArgs e)
        {
            //Validation
            if (String.IsNullOrWhiteSpace(TextBoxName.Text) || String.IsNullOrWhiteSpace(TextBoxCode.Text) || String.IsNullOrWhiteSpace(ComboBoxCase.Text))
            {
                MessageBox.Show("Fill all fields", "Wrong input");
                return;
            }
            if (!Regex.IsMatch(TextBoxName.Text, "^[a-zA-Z ]*$"))
            {
                MessageBox.Show("Name must be letters", "Wrong input");
                return;
            }

            //Adding a new UnderCase
            string text = ComboBoxCase.SelectedItem as string;
            var x = from Case in db.Cases
                    where (Case.Name + " " + Case.CaseCode) == text
                    select Case.CaseId;

            var UnderCase = new UnderCase() { Name = TextBoxName.Text, UnderCaseCode = TextBoxCode.Text, CaseId = x.ToList().First() };
            db.UnderCases.Add(UnderCase);
            db.SaveChanges();
            MessageBox.Show("New undercase is added to base", "New data");
            TextBoxName.Clear();
            TextBoxCode.Clear();
            ComboBoxCase.SelectedIndex = -1;
            Fill();
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var x = from UnderCase in db.UnderCases
                    where UnderCase.Name.Contains(TextBoxSearch.Text) || UnderCase.UnderCaseCode.Contains(TextBoxSearch.Text)
                    select UnderCase;

            DataGrid1.DataContext = x.ToList();
        }

        private void Button_ClickRefresh(object sender, RoutedEventArgs e)
        {
            Fill();
            FillCombo();
        }
    }
}
