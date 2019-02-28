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
    /// Interaction logic for Task.xaml
    /// </summary>
    public partial class TaskWindow : Window
    {
        LOContext db = new LOContext();
        //Method for filling DataGrids
        public void Fill()
        {
            LOContext db = new LOContext();
            var query = from Task in db.Tasks
                        select Task;
            DataGrid1.DataContext = query.ToList();
        }

        //Method for filling ComboBox-a
        public void FillCombo()
        {
        var query = from UnderCase in db.UnderCases
                    select UnderCase.Name + " " + UnderCase.UnderCaseCode;
        ComboBoxUnderCase.DataContext = query.ToList();
        }

        public TaskWindow()
        {
            InitializeComponent();
            Fill();
            FillCombo();
                //Hidden button if not admin
                if (Utility.UserAdmin == false)
            {
                ButtonDelete.Visibility = Visibility.Hidden;
            }

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
            if (String.IsNullOrWhiteSpace(TextBoxSpendTime.Text) || String.IsNullOrWhiteSpace(datePicker1.Text) || String.IsNullOrWhiteSpace(ComboBoxUnderCase.Text) || String.IsNullOrWhiteSpace(datePicker1.Text))
            {
                MessageBox.Show("Fill all fields", "Wrong input");
                return;
            }

            if (!Regex.IsMatch(TextBoxSpendTime.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Spend time must be numbers", "Wrong input");
                return;
            }

            //Adding a new Task
            string text = ComboBoxUnderCase.SelectedItem as string;
            var query = from UnderCase in db.UnderCases
                        where (UnderCase.Name + " " + UnderCase.UnderCaseCode) == text
                        select UnderCase.UnderCaseId;

            var Task = new Task() { Description = TextBoxDescription.Text, SpendTime = Convert.ToInt32(TextBoxSpendTime.Text), Date = datePicker1.SelectedDate.Value, UnderCaseId = query.ToList().First() };
            db.Tasks.Add(Task);
            db.SaveChanges();
            MessageBox.Show("New task is added to base", "New data");
            TextBoxDescription.Clear();
            TextBoxSpendTime.Clear();
            ComboBoxUnderCase.SelectedIndex = -1;
            datePicker1.SelectedDate = null;
            Fill();
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from Task in db.Tasks
                        where Task.Description.Contains(TextBoxSearch.Text)
                        select Task;

            DataGrid1.DataContext = query.ToList();
        }


        private void Button_ClickDelete(object sender, RoutedEventArgs e)
        {
            //Delete Task
            if (DataGrid1.SelectedCells.Count > 0)
            {
                Task da = (Task)DataGrid1.SelectedItem;
                var query = from Task in db.Tasks
                            where Task.TaskId == da.TaskId
                            select Task;
                db.Tasks.Remove(query.ToList().First());
                db.SaveChanges();
                Fill();
                MessageBox.Show("Task deleted","Successful delete");
            }
            else
            {
                MessageBox.Show("No selection", "Error");
            }
        }

        private void Button_ClickRefresh(object sender, RoutedEventArgs e)
        {
            Fill();
            FillCombo();
        }
    }
}
