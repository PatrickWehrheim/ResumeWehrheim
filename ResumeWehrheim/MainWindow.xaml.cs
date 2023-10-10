using System;
using System.Windows;
using ResumeWehrheim.Models;
using ResumeWehrheim.Schools;
using ResumeWehrheim.Companies;
using System.Windows.Navigation;

namespace ResumeWehrheim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Application.Current.MainWindow.Content = new Pages.Home();
        }        
    }
}
