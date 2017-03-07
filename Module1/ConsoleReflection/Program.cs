using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReflection
{
    class Program
    {

        static void Main(string[] args)
        {
            Type[] oTypes;
     
            string nameClass,strMethod;
            Assembly oAssembly;
            oAssembly = Assembly.LoadFrom("D:\\LTHDT\\Advanced-.Net-Propgaming\\Module1\\RelectionDemo\\bin\\Debug\\RelectionDemo.dll");
            oTypes = oAssembly.GetTypes();
            foreach (Type item in oTypes)
            {
                Console.WriteLine("Class {0}", item.Name);
                Console.WriteLine("FullName {0}", item.FullName);

            }
            Console.WriteLine("input Class:");
            nameClass = Console.ReadLine();
            object obj = oAssembly.CreateInstance(nameClass);
            // get name method
            foreach (var items in obj.GetType().GetMethods())
            {
                Console.WriteLine("\n Name Method is :" + items.Name);
            }
            Console.WriteLine("Input method :");
            strMethod = Console.ReadLine();
            var methodInfo = obj.GetType().GetMethod(strMethod);
            if (methodInfo != null)
            {
                var param = methodInfo.GetParameters();
                if (param.Length > 0)
                {
                    object[] objpara = new object[param.Length];
                    for (int i = 0; i < param.Length; i++)
                    {
                        if (param[i].ParameterType == typeof(String))
                        {
                            Console.WriteLine("input parameter type string");
                            string parstring = Console.ReadLine();
                            objpara[i++] = parstring;
                        }
                        else if(param[i].ParameterType == typeof(Int32))
                        {
                            Console.WriteLine("input parameter type int");
                            int k;
                            string s;
                            s = Console.ReadLine();
                            k = Int32.Parse(s);
                            objpara[i++] = k;
                        }

                    }
                }
            }

            Console.ReadLine();

        }
    }
}
