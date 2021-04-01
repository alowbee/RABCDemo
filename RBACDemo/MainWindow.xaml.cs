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
using WPFToolkit.Controls;

namespace SqliteDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : CustomWindow
    {
        private SignInWindow signinWindow = new SignInWindow();
        private UserPage userPage = new UserPage();
        private UserGroupPage userGroupPage = new UserGroupPage();
        private GroupPage groupPage = new GroupPage();
        private ActionPage actionPage = new ActionPage();
        private GroupActionPage groupActionPage = new GroupActionPage();
        public static MainWindowVM viewmodel = new MainWindowVM();
        public MainWindow()
        {
            signinWindow.ShowDialog();
            InitializeComponent();
            this.DataContext = viewmodel;
            viewmodel.SubContent = userPage;
        }


 

        private void User_Click(object sender, RoutedEventArgs e)
        {
            viewmodel.SubContent = userPage;
        }

        private void Action_Click(object sender, RoutedEventArgs e)
        {
            viewmodel.SubContent = actionPage;
        }

        private void Group_Click(object sender, RoutedEventArgs e)
        {
            viewmodel.SubContent = groupPage;
        }

        private void UserGroup_Click(object sender, RoutedEventArgs e)
        {
            viewmodel.SubContent = userGroupPage;
        }

        private void GroupAction_Click(object sender, RoutedEventArgs e)
        {
            viewmodel.SubContent = groupActionPage;
        }
    }
}
