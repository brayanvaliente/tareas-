using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Crear una clase que se identifica a un empleado. Definir como atributos su nombre y 
 su sueldo. Enel constructor cargar los atributos y luego en otro método imprimir sus 
 datos y por último uno queimprima un mensaje si debe pagar impuestos 
 (si el sueldo es mayor a $3000)
     */
namespace ejerccio2
{
    public class empleado
    {
        string nombre;
        double sueldo;

        public empleado(string r, double x)
        {
            this.nombre = r;
            this.sueldo = x;
        }

        public void imprimir()
        {
            Console.WriteLine("Nombre del empleado es: " + nombre);
            Console.WriteLine("sueldo del empleado es: " + (sueldo));
            if (sueldo > 3000)
            {
                Console.WriteLine("debe pagar impuestos ");
            }
        }


    }
}
