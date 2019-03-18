using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    public class operaciones
    {
        int val1, val2;
        public operaciones(int val1,int val2) {
            this.val1 = val1;
            this.val2 = val2;
        }
        public void imprrimirsuma() {
            Console.WriteLine("suma: "+(val1+val2));
            
        }
        public void imprrimirresta()
        {
            Console.WriteLine("resta: " + (val1 - val2));

        }
        public void imprrimirmulti()
        {
            Console.WriteLine("multipliacion: " + (val1 * val2));

        }
        public void imprrimirdiv()
        {
            double d = val1 / val2;
            Console.WriteLine("division: " + (d));

        }
    }
}
