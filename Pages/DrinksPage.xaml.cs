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
    public partial class DrinksPage : Page
    {
        public DrinksPage()
        {
            InitializeComponent();
        }

        private void AddDrinkBtn_Click(object sender, RoutedEventArgs e)
        {
            AddDrink drink = new AddDrink();
            drink.ShowDialog();
        }

        private void DelDrinkBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LVItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DrinkViewInfo viewInfo = new DrinkViewInfo();
            viewInfo.ShowDialog();
        }
    }
}
