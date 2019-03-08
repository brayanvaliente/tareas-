using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Class1
    {

        int val1=4, val2=5, suma;
        public void imprimir(){
            suma = val1 + val2;
            Console.WriteLine("la suma es " + suma);
        }

        public void imprimir(int valor1){
            suma = val1 + valor1;
            Console.WriteLine("la suma es " + suma);
        }

        public void imprimir(int valor1, int valor2)
        {
            suma = valor1 + valor2;
            Console.WriteLine("la suma es " + suma);
        }
    }
}
