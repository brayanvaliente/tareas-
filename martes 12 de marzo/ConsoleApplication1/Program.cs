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
            cliente obj = new cliente();
                
                obj.depositar(35);
                obj.retirar("brayan", 10);
                Console.ReadKey();


               
            
        }
    }
}
