﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string password;
        int passwordLength = 0;
        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text.Equals("admin") && password == "admin")
            {
                InfoTextBlock.Text = "U wordt ingelogd.";
            }
        }

        private void LogOffButton_Click(object sender, RoutedEventArgs e)
        {
            InfoTextBlock.Text = "";
        }

        private void PasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}