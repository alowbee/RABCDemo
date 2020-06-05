using RBACDemo.Assist;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RBACDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            string DBPath = "G:/Desktop/SqliteDemo/SqliteDemo/DemoDBFile.db";
            //string DBPath= "pack://application:,,,/SqliteDemo/DemoDBFile.db";
            string tableName = "AppUser";
            List<string> fieldlist = new List<string>() {"ID","Name","Password"};
            List<string> typelist = new List<string>() { FieldTypeAssist.INTEGERType, FieldTypeAssist.TEXTType, FieldTypeAssist.TEXTType };
            DBFileAssist.CreatTable(DBPath,tableName,fieldlist,typelist);
        }
    }
}
