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
    public class club
    {
        int I, may = 0;
        socio obj1, obj2, obj3;
        retAsig obj4 = new retAsig();

     
        public void  club1() {
            obj1 = new socio("brayan",32);
            obj2 = new socio("carlos",66);
            obj3 = new socio("jorge",23);
        }
        public void mayors()
        {
           
            for (int i = 0; i < 3; i++)
            {

                if (may <= obj4.RetAsig)
                {
                    may = obj4.RetAsig;
                }

               
            }
            Console.WriteLine("Socio mas antiguo es : " +may);
        }
    }
}
