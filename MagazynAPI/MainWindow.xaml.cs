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

namespace MagazynAPI
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void logbut_Click(object sender, RoutedEventArgs e)
        {
            string pass = passBox.Password;
            string login = logBox.Text;
            MagazynList magazynWindow = new MagazynList();
            if(login == "admin" && pass =="1234")
            {
                Content = magazynWindow;
            }
            else
            labmessage.Content = "Login lub hasło są niepoprawne";
        }
    }
}
