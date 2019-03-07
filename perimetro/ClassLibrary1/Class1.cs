using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class areas
    {
        public double bases;
        public double alturas;

        public void setbases(double valor)
        {
            bases = valor;

        }

        public double getbases()
        {
            return bases;

        }

        public void setalturas(double valor)
        {
            alturas = valor;

        }

        public double getalturas()
        {
            return bases;

        }

        public void imprimir()
        {
            Console.WriteLine("el perimetro de un cuadrados es"+((bases*2)+(alturas*2)));
        } 



    }

    
}
