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
    public class socio
    {
        private string nombre;
        private int antiguedad;
        public socio(string nombre, int antiguedad)
        {
            this.nombre = nombre;
            this.antiguedad = antiguedad;
        }

        public socio()
        {
        }

        public void asigmbre(string valor1)
        {
            nombre = valor1;
        }
        public string retNombre(){
            return nombre;
        }

        public void asigAnti(int valor2)
        {
            antiguedad = valor2;
        }
        public int retAsig()
        {
            return antiguedad;
        }

        public void imprimir() {
            Console.WriteLine("su nombre es: " + retNombre());
            Console.WriteLine("su antiguedad es: " + retAsig());

        }

    }

    class retAsig
    {
        public retAsig()
        {
        }

        public int RetAsig { get; internal set; }
    }
}
    
