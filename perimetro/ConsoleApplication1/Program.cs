using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            areas obj = new areas();

            obj.setbases(4);
            Console.WriteLine(obj.getbases());

            obj.setalturas(4);
            Console.WriteLine(obj.getalturas());
            obj.imprimir();
            Console.ReadKey();

        }
    }
}
