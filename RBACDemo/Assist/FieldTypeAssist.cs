using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RBACDemo.Assist
{
    /// <summary>
    /// 防止程序员建表时类型名称写错
    /// </summary>
    public static class FieldTypeAssist
    {
        public static string INTEGERType = "INTEGER";
        public static string TEXTType = "TEXT";
        public static string BLOBType = "BLOB";
        public static string REALType = "REAL";
        public static string NUMERICType = "NUMERIC";

    }
}
