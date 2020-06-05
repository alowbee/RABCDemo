using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RBACDemo.Assist
{

    public class DBFileAssist
    {


        //创建DB文件
        public static void CreateDBfile(string DBpath)
        {

            if (!File.Exists(DBpath))
            {
                SQLiteConnection.CreateFile(DBpath);
            }

        }

        //创建表
        public static void CreatTable(string DBpath, string tableName, List<string> field, List<string> type)
        {
            CreateDBfile(DBpath);
            SQLiteConnection connection = new SQLiteConnection("data source=" + DBpath);
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            SQLiteCommand command = new SQLiteCommand();
            var temppartcmd = string.Empty;
            if (field.Count != type.Count)
            {
                MessageBox.Show("数据表字段和类型数量不对应");
            }
            else
            {
                for (int i = 0; i < field.Count - 1; i++)
                {
                    temppartcmd += field[i] + " " + type[i] + ",";
                }
                temppartcmd += field[field.Count - 1] + " " + type[type.Count - 1];

            }

            command.CommandText = "CREATE TABLE " + tableName + "(" + temppartcmd + ")";
            command.ExecuteNonQuery();
            connection.Close();
        }














    }

}

