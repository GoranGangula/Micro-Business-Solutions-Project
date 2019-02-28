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
  
    public partial class Manu : Window
    {
        public Manu()
        {
            InitializeComponent();
        }

        private void Button_ClickExitManu(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close(); ;
        }

        private void Button_Click_Lawyer(object sender, RoutedEventArgs e)
        {
            
            WindowLawyer win = new WindowLawyer();
            win.Show();
            this.Close();
        }

        private void Button_Click_Client(object sender, RoutedEventArgs e)
        {
           
            WindowClient win = new WindowClient();
            win.Show();
            this.Close();
        }

        private void Button_Click_Case(object sender, RoutedEventArgs e)
        {
            CasesWindow win = new CasesWindow();
            win.Show();
            this.Close();
        }

        private void Button_Click_UnderCase(object sender, RoutedEventArgs e)
        {
            UnderCaseWindow win = new UnderCaseWindow();
            win.Show();
            this.Close();
        }

        private void Button_Click_Task(object sender, RoutedEventArgs e)
        {
            TaskWindow win = new TaskWindow();
            win.Show();
            this.Close();
        }
    }
}
