using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Reflection
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int i = 42;
            System.Type type = i.GetType();
            System.Console.WriteLine(type);
        }
        static void Main(string[] args)
        {
            Assembly a = Assembly.Load("mscorlib.dll");
            //System.Console.WriteLine(o.GetName());
            Type[] types= a.GetTypes();

           



           // foreach(Type t in types)
           // {
             //   Console.WriteLine("Types is {0}", t);
           //}
            Console.WriteLine("{0} types found",types.Length);


            var libtypes = types.Where(t => t.FullName.Contains("int"));
            foreach(var libtype in libtypes)
            {
                if (libtype.Name.Contains("Object"))
                {
                    Console.WriteLine(libtype.Name);
                    Console.WriteLine("----------");
                    foreach(var item in libtype.GetMethods())
                    {
                        Console.WriteLine(item.Name);
                    }
                }
               
            }
           Console.ReadKey();

        }
    }
}
