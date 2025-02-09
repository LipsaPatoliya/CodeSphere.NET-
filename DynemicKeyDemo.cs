using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemoTask
{
    internal class DynemicKeyDemo
    {
        //dynamic variable can be use as paramter  
        public static void show(dynamic a) 
        {
            Console.WriteLine(a);
        }
        //Dynamic key are use to all data type
        static void Main(string[] args) 
        {
            DynemicKeyDemo.show("aelsi");
            DynemicKeyDemo.show(200);
/*
            dynamic a = 10;
            a = "Aelsa"; //can be also change varible for initial time in dynamoc keyword
            Console.WriteLine(a.GetType());
            Console.WriteLine(a);
*/
            Console.ReadLine();
        } 
    }
}
