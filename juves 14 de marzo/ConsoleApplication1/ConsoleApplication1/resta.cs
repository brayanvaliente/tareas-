using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class resta : control
    {
        public void resOp()
        {
            Resultado = Valor1 - Valor2;
            Console.WriteLine(Resultado);
        }
    }
}
