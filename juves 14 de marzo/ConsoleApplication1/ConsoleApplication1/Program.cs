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
            suma objsuma = new suma();
            resta objresta = new resta();
            
            objsuma.Valor1 = 50;
            objsuma.Valor2 = 50;
            objresta.Valor1 = 50;
            objresta.Valor2 = 50;
            objsuma.sumOp();
            objresta.resOp();
            Console.ReadKey();
            
        }
    }
}
