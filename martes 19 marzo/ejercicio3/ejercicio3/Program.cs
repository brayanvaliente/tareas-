using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            operaciones obj = new operaciones(30,6);
            obj.imprrimirsuma();
            obj.imprrimirresta();
            obj.imprrimirmulti();
            obj.imprrimirdiv();
            Console.ReadKey();
        }
    }
}
