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
using WpfApp1.Pages;

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEmployeeWndw.xaml
    /// </summary>
    public partial class AddEmployeeWndw : Window
    {
        EmployeesPage page;
        public AddEmployeeWndw()
        {
            InitializeComponent();
            page = new EmployeesPage();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
          
            
        }
        private void MainGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }
    }
}
