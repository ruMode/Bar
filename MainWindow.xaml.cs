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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            Windows.Login login = new Windows.Login();

            
            if (login.ShowDialog() == false)
            {
                Application.Current.Shutdown();
            }

        }

        #region Тулбар
        private void MinimizedWindowBtn_Click(object sender, RoutedEventArgs e)
        {
           WindowState= WindowState.Minimized;
        }

        private void FullScreenWindowBtn_Click(object sender, RoutedEventArgs e)
        { 
            WindowState = WindowState.Maximized;
            
        }

        private void CloseWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void WindowToolbarGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }
        #endregion

        #region Обрботчики айтемов меню
        private void EmployeesLVI_Selected(object sender, RoutedEventArgs e)
        { 
            Pages.EmployeesPage page = new Pages.EmployeesPage();
            frameMain.Navigate(page);
        }
        
        private void DrinksLVI_Selected(object sender, RoutedEventArgs e)
        {
            Pages.DrinksPage page = new Pages.DrinksPage();
            frameMain.Navigate(page);
        }

        private void suppliersLVI_Selected(object sender, RoutedEventArgs e)
        {
            Pages.SuppliersPage page = new Pages.SuppliersPage();
            frameMain.Navigate(page);
        }

        private void documentsLVI_Selected(object sender, RoutedEventArgs e)
        {
            Pages.DocumentsPage page = new Pages.DocumentsPage();
            frameMain.Navigate(page); 
        }

        private void settingsLVI_Selected(object sender, RoutedEventArgs e)
        {
            Pages.SettingsPage page = new Pages.SettingsPage();
            frameMain.Navigate(page);
        }
        private void snacksLVI_Selected(object sender, RoutedEventArgs e)
        {
            Pages.SnacksPage page = new Pages.SnacksPage();
            frameMain.Navigate(page);
        }

        #endregion

    }
}
