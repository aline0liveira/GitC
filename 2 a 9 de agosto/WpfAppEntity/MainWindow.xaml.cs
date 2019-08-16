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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppEntity
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginFrorm_sucess(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
            loginFrorm.Visibility = Visibility.Hidden;
            ucGridView.Visibility = Visibility.Visible;
        }

        private void LoginFrorm_fail(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
    }
}