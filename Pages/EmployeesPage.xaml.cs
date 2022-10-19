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
using WpfApp1.Windows;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        public EmployeesPage()
        {
            InitializeComponent();

     
        }

        private void AddNewEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWndw newEmployee = new AddEmployeeWndw();
            newEmployee.ShowDialog();
        }

        private void DelEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void LVItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            EnployeeViewInfo viewInfo = new EnployeeViewInfo();
            viewInfo.ShowDialog();
        }
    }
}
