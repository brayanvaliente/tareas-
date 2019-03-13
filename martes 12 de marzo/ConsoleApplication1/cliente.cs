using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class cliente
    {
        string nombre;
        double monto;

        public cliente()
        {
            this.nombre = "";
            this.monto = 0;
        }
        public void depositar(double a){
            monto = a;
        }
        public void retirar(string nom, double b){
            Console.WriteLine("ingrese su nombre : "+ nom + "\nsu retiro es: "+(monto-b));
        }

    }
}
