using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    public class bancos
    {
        clientes obj1, obj2, obj3;
        public bancos() {
            obj1 = new clientes("brayan");
            obj2 = new clientes("juan");
            obj3 = new clientes("jorge");
        }
        public void operaciones() {
            obj1.deposito(233);
            obj2.deposito(656);
            obj3.deposito(656);
            obj3.retiro(100);

        }
        public void resultados() {
            double resutaldo = obj1.retmonto() + obj2.retmonto() + obj3.retmonto();
            Console.WriteLine(resutaldo);
        }

    }
}
