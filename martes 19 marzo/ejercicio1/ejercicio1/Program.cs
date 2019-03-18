using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear una clase Club y otra clase Socio.
La clase Socio debe tener los siguientes atributos privados: nombre y la antigüedad en el club (en
años). En el constructor pedir la carga del nombre y su antigüedad. La clase Club debe tener como
atributos 3 objetos de la clase Socio. Definir una responsabilidad para imprimir el nombre del
socio con mayor antigüedad en el club.
 */ 
namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            club obj = new club();
          

            socio obj5 = new socio();
            obj5.imprimir();

           
            Console.ReadKey();

        }
    }
}
