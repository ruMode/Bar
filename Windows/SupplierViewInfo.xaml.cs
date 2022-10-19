﻿using System;
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
    /// Логика взаимодействия для AddEmployeeWndw.xaml
    /// </summary>
    public partial class SupplierViewInfo : Window
    {
        public SupplierViewInfo()
        {
            InitializeComponent();
        }

        private void bankAccount_Click(object sender, RoutedEventArgs e)
        {
            BankAccoutView accView = new BankAccoutView();
            accView.ShowDialog();
        }

       
    }
}
