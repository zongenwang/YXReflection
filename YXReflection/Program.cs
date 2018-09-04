using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Reflection;
using YX.DB.Interface;
using YX.DB.MySql;
using YX.DB.SqlServer;
using YX.Model;

namespace YXReflection
{
    /// <summary>
    /// 1.dll-IL-metadata-反射
    /// 2.反射加载dll,读取module、类、方法、特性
    /// 3.反射创建对象，反射+简单工厂+配置文件  选修：破坏单例 创建泛型
    /// 4.反射调用实例方法、静态方法、重载方法  选修：调用私有方法 调用泛型方法
    /// 5.反射字段和属性，分别获取值和设置值
    /// 6.反射的好处和局限
    /// 反射：System.Reflection .Net框架提供帮助类库，可以读取并使用metadata
    /// 反射优点：动态
    ///     缺点： 1写起来复杂 
    ///            2避开编译器的检查
    ///            3性能问题
    ///            100w次 性能差别500倍
    ///            7300ms  100次0.73ms  绝对值很小 绝大部分情况不影响你的程序性能
    ///            性能优化，空间换时间  差别7倍  绝对更是小了  10000次才0.87
    ///            MVC第一次访问很慢  后面很快
    ///            EF第一次使用很慢  后面很快
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {
                //    Console.WriteLine("****************Common*******************");
                //    IDBHelper iDBHelper = new MySqlHelper();
                //    iDBHelper.Query();

                //    //typeof(MySqlHelper);
                //    //iDBHelper.GetType();
                //}
                //{
                //    Console.WriteLine("****************Common*******************");
                //    IDBHelper iDBHelper = new SqlServerHelper();
                //    iDBHelper.Query();
                //}

                //{
                //    Console.WriteLine("****************Reflection*******************");
                //    Assembly assembly = Assembly.Load("YX.DB.MySql");//dll名称无后缀 从当前目录加载  1 加载dll
                //    //Assembly.LoadFile("") 完整路径的加载，可以是别的目录  加载不会错，但是如果没有依赖项，使用的时候会错
                //    //Assembly.LoadFrom("YX.DB.MySql.dll");//带后缀或者完整路径

                //    foreach (var item in assembly.GetModules())
                //    {
                //        Console.WriteLine(item.FullyQualifiedName);
                //    }
                //    foreach (var item in assembly.GetTypes())
                //    {
                //        Console.WriteLine(item.FullName);
                //    }

                //    Type type = assembly.GetType("YX.DB.MySql.MySqlHelper");//2.获取类型信息
                //    object oDBHelper = Activator.CreateInstance(type);//3 创建对象
                //    //oDBHelper.Query();//oDBHelper是object不能调用，但实际上方法是有的  编译器不认可
                //    IDBHelper iDBHelper = (IDBHelper)oDBHelper;//4 类型转换
                //    iDBHelper.Query();//5.方法调用
                //}

                //{
                //    //IOC
                //    Console.WriteLine("**********************Reflection +Factory+Config***************************");
                //    IDBHelper iDBHelper = Factory.CreateHelper();
                //    iDBHelper.Query();  //可配置  可扩展  反射是动态的  依赖的是字符串
                //}
                //{
                //    Console.WriteLine("************************Reflection+Instance****************************");
                //    // Singleton singleton = new Singleton();
                //    Singleton sinleton1 = Singleton.GetInstance();
                //    Singleton sinleton2 = Singleton.GetInstance();
                //    Singleton sinleton3 = Singleton.GetInstance();
                //    {
                //        //反射构建单例模式类
                //        Assembly assembly = Assembly.Load("YX.DB.SqlServer");
                //        Type type = assembly.GetType("YX.DB.SqlServer.Singleton") ;
                //        Singleton singleton4 = (Singleton)Activator.CreateInstance(type, true);
                //        Singleton singleton5 = (Singleton)Activator.CreateInstance(type, true);
                //        Singleton singleton6 = (Singleton)Activator.CreateInstance(type, true);
                //    }

                //    {
                //        //反射构建 构造方法
                //        Assembly assembly = Assembly.Load("YX.DB.SqlServer");
                //        Type type = assembly.GetType("YX.DB.SqlServer.ReflectionTest");
                //        object oReflectionTest1 = Activator.CreateInstance(type);
                //        object oReflectionTest2 = Activator.CreateInstance(type, new object[] { 123 });
                //        object oReflectionTest3 = Activator.CreateInstance(type,new object[] { "123"});
                //    }

                //    //反射构建 泛型类
                //    {
                //        Assembly assembly = Assembly.Load("YX.DB.SqlServer");
                //        Type type = assembly.GetType("YX.DB.SqlServer.GenericClass~3");
                //        //object oGeneric = Activator.CreateInstance(type);  泛型不能直接创建对象，要给出数据类型后才能创建实例；

                //        Type newType = type.MakeGenericType(new Type[] { typeof(int), typeof(string), typeof(DateTime) });
                //        object oGeneric = Activator.CreateInstance(newType);
                //    }
                //}
                //{
                //    //MVC URL地址一类名称+方法名称
                //    Console.WriteLine("*************************Reflection+Method*******************************");
                //    Assembly assembly = Assembly.Load("YX.DB.SqlServer");
                //    Type type = assembly.GetType("YX.DB.SqlServer.ReflectionTest");
                //    object oReflectionTest = Activator.CreateInstance(type);
                //    foreach (var item in type.GetMethods())
                //    {
                //        Console.WriteLine((item.Name));
                //    }
                //    //oReflectionTest.Show1();
                //    {
                //        MethodInfo method = type.GetMethod("Show1");
                //        method.Invoke(oReflectionTest, null);
                //    }
                //    //oReflectionTest.Show2();
                //    {
                //        MethodInfo method = type.GetMethod("Show2");
                //        method.Invoke(oReflectionTest, new object[] { 123 });
                //    }
                   
                //    //方法重载  记得加参数个数
                //    {
                //        //方法无参数
                //        MethodInfo method = type.GetMethod("Show3", new Type[] { });
                //        method.Invoke(oReflectionTest, new object[] { });
                //    }

                //    {
                //        MethodInfo method = type.GetMethod("Show3", new Type[] { typeof(int) });
                //        method.Invoke(oReflectionTest, new object[] { 123 });
                //    }

                //    {
                //        MethodInfo method = type.GetMethod("Show3", new Type[] { typeof(string) });
                //        method.Invoke(oReflectionTest, new object[] { "Ant" });
                //    }
                //    {
                //        MethodInfo method = type.GetMethod("Show3",new Type[] { typeof(int),typeof(string)});
                //        method.Invoke(oReflectionTest, new object[] { 234, "W" });
                //    }
                //    {
                //        MethodInfo method = type.GetMethod("Show3", new Type[] { typeof(string), typeof(int) });
                //        method.Invoke(oReflectionTest, new object[] { "W", 234});
                //    }
                //    //
                //    {
                //        MethodInfo method = type.GetMethod("Show4", BindingFlags.Instance|BindingFlags.NonPublic );
                //        method.Invoke(oReflectionTest, new object[] { "天空之上" });
                //    }

                //    //静态方法调用
                //    {
                //        MethodInfo method = type.GetMethod("Show5");
                //        method.Invoke(oReflectionTest, new object[] { "麦田的稻草人" });
                //        method.Invoke(null, new object[] { "果然" });  //静态方法的调用
                //    }

                //    {
                //        //自带一个参数的泛型类，方法带两个泛型类
                //        Type typeGenericDouble = assembly.GetType("Ruanmou.DB.SqlServer.GenericDouble`1");
                //        Type newType = typeGenericDouble.MakeGenericType(new Type[] { typeof(int) });
                //        object oGeneric = Activator.CreateInstance(newType);
                //        MethodInfo method = newType.GetMethod("Show");
                //        MethodInfo methodNew = method.MakeGenericMethod(new Type[] { typeof(string), typeof(DateTime) });
                //        methodNew.Invoke(oGeneric, new object[] { 123, "流浪诗人", DateTime.Now });
                //    }
                    //ORM（Object Relational Mapping）框架采用元数据来描述对象,关系映射细节，
                    //元数据一般采用XML格式，并且存放在专门的对象一映射文件中。
                    { 
                    Console.WriteLine("************************Reflection+Property/Field*****************");
                    People people = new People();
                    people.Id = 123;
                    people.Name = "Lutte";
                    people.Description = "高级班的新学员";

                    Console.WriteLine($"people.Id={people.Id}");
                    Console.WriteLine($"people.Name={people.Name}");
                    Console.WriteLine($"people.Description={people.Description}");

                        Assembly assembly = Assembly.Load("YX.Model");
                        Type type = assembly.GetType("YX.Model.People");
                       // Type type = typeof(People);
                        object oPeople = Activator.CreateInstance(type);
                        //获取属性
                        foreach (var prop in type.GetProperties())
                        {
                            Console.WriteLine(type.Name);
                            Console.WriteLine(prop.Name);
                            Console.WriteLine(prop.GetValue(oPeople));
                            if (prop.Name.Equals("Id"))
                            {
                                prop.SetValue(oPeople, 234);
                            }
                            else if (prop.Name.Equals("Name"))
                            {
                                prop.SetValue(oPeople, "风潇潇");
                            }
                            Console.WriteLine($"{type.Name}.{prop.Name}={prop.GetValue(oPeople)}");
                        }
                        //获取字段
                        foreach (var field in type.GetFields())
                        {
                            Console.WriteLine(type.Name);
                            Console.WriteLine(field.Name);
                            Console.WriteLine(field.GetValue(oPeople));
                            if (field.Name.Equals("Description"))
                            {
                                field.SetValue(oPeople, "高级班的新学员");
                            }
                            Console.WriteLine($"{type.Name}.{field.Name}={field.GetValue(oPeople)}");
                        }

                    }                
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
