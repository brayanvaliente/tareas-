using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        private double monto;
        private string nombre;

       public Class1() {
            this.monto = 0;
            this.nombre = "";
        }

        public Class1(double var1)
        {
            monto = var1;
        }
        public void imp(){
            Console.WriteLine(monto);
        
        }
        

    }
}
