using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {


        static void Main(string[] args)
        {
            double montos;
            Console.WriteLine("ingrese montos");
            montos = double.Parse(Console.ReadLine());
            Class1 obj = new Class1(montos);
            obj.imp();
           
            Console.ReadKey();

            
        }

    }
}
