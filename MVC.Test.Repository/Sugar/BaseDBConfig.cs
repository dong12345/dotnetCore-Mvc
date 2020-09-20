using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Test.Repository.Sugar
{
    public  class BaseDBConfig
    {
        //public static string ConnectionString = File.ReadAllText(@"D:\my-file\dbCountPsw1.txt").Trim();

        //正常格式  - 因ioc注入所以不能使用
        //public static string ConnectionString = "server=.;uid=sa;pwd=sa;database=AppsDB_new"; 

        //ioc注入使用
        //public static string ConnectionString = Appsettings.app(new string[] { "AppSettings", "SqlServer", "SqlServerConnection" });//获取连接字符串
        public static string ConnectionString = "server=.;uid=sa;pwd=sa;database=SNEC";
    }
}
