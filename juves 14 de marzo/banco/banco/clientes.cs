using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    public class clientes
    {
        private string nombre;
        private double monto;

        public clientes()
        {
            this.nombre = "";
            this.monto = 0.0;
        }
        public clientes(string nombres)
        {
            this.nombre = nombres;
            this.monto = 0.0;
        }

        public void deposito(double valor)
        {
            monto = monto + valor;
        }
        public void retiro(double valor)
        {
            monto = monto - valor;
        }
        public double retmonto()
        {
            return monto;
        }
    }
}
