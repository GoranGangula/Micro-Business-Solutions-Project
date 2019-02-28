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

namespace LawOffice
{
    /// <summary>
    /// Interaction logic for SelectedTask.xaml
    /// </summary>
    public partial class SelectedTask : Window
    {
        LOContext db = new LOContext();
        public SelectedTask(List<Task> DataObject)
        {
            InitializeComponent();
            DataGrid1.DataContext = DataObject;
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from Task in db.Tasks
                        where Task.Description.Contains(TextBoxSearch.Text)
                        select Task;

            DataGrid1.DataContext = query.ToList();
        }
    }
}
