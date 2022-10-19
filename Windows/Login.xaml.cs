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

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public void DragWindow()
        {
           
        }
        public Login()
        {
            InitializeComponent();
            LoginFormGrid.Visibility = Visibility.Visible;
            LostPassGrid.Visibility = Visibility.Hidden;
            BackLoginFormBtn.Visibility = Visibility.Hidden;
        }

        private void LostPassLabel_Click(object sender, RoutedEventArgs e)
        {
            LoginFormGrid.Visibility = Visibility.Hidden;
            BackLoginFormBtn.Visibility = Visibility.Visible;
            LostPassGrid.Visibility = Visibility.Visible;
        }

        private void CloseLoginForm_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BackLoginForm_Click(object sender, RoutedEventArgs e)
        {
            LostPassGrid.Visibility = Visibility.Hidden;
            LoginFormGrid.Visibility = Visibility.Visible;
            BackLoginFormBtn.Visibility = Visibility.Hidden;
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            //
            //реализовать проверку введенных данных с доступными юзерами в бд
            //

            if (LoginBox.Text == "1" & PassBox.Password=="1")
            {
               DialogResult = true;
            }
        }

        private void ResetPassBtn_Click(object sender, RoutedEventArgs e)
        {
            CodeFromEMail.Visibility = Visibility.Visible;

            //место для реализации функции отправки кода восстановления пароля
            //на указанную почту, если таковая зарегана в базе

        }

        private void WindowToolbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton==MouseButton.Left)
            {
                DragMove();
            }
        }
    }
}
