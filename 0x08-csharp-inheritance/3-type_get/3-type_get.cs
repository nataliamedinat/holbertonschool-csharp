using System;
using System.Collections.Generic;
using System.Reflection;

    /// <summary> Object class </summary>
    class Obj
    {
        /// <summary> Prints the names of the available properties and methods of an object.</summary>
        public static void Print(object myObj)
        {
            Type o = myObj.GetType();
            MethodInfo[] methods = o.GetMethods();
            PropertyInfo[] properties = o.GetProperties();
            Console.WriteLine($"{o.Name} Properties:");
            foreach (var p in o.GetProperties())
            {
                Console.WriteLine($"{p.Name}");
            }
            Console.WriteLine($"{o.Name} Methods:");
             foreach(MethodInfo method in methods) 
            {
                Console.WriteLine(method.Name);
            }
        }
    }
