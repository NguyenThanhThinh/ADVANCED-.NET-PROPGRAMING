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
            string nameClass;
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
            foreach (MethodInfo items in obj.GetType().GetMethods())
            {
                Console.WriteLine("Method" + items.Name);
            }
            Console.ReadLine();

        }
    }
}
