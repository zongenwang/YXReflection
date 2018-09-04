using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YX.DB.Interface;
using System.Configuration;
using System.Reflection;


namespace YXReflection
{
    /// <summary>
    /// 创建对象
    /// </summary>
  public  class Factory
    {
        private static string IDBHelperConfig = ConfigurationManager.AppSettings["IDBHelperConfig"];
        private static string DllName = IDBHelperConfig.Split(',')[1];
        private static string TypeName = IDBHelperConfig.Split(',')[0];

        public static IDBHelper CreateHelper()
        {
            Assembly assemebly = Assembly.Load(DllName);  //1.加载dll程序集
            Type type = assemebly.GetType(TypeName);      //2.获取类型信息
            object oDBHelper = Activator.CreateInstance(type); //3.创建对象
            IDBHelper iDBHelper = (IDBHelper)oDBHelper;       //4.类型转换
            return iDBHelper;
        }
    }
}
