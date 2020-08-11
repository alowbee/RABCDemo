using RBACDemo;
using RBACDemo.Pages;
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

namespace SqliteDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private SignInWindow loginwin = new SignInWindow();
        private UserPage userPage = new UserPage();
        private GroupPage groupPage = new GroupPage();
        private ActionPage actionPage = new ActionPage();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Login_Click(object sender, RoutedEventArgs e)
        {         
            loginwin.Show();
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = userPage;
        }

        private void Action_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = actionPage;
        }

        private void Group_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = groupPage;
        }
    }
}
