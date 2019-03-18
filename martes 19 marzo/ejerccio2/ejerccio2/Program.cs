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
    public class Program
    {
        static void Main(string[] args)
        {
            string nom;
            double suel;
            Console.WriteLine("ingrese nombre de empleado: ");
            nom = Console.ReadLine();
            Console.WriteLine("ingrese sueldo de empleado");
            suel = double.Parse(Console.ReadLine());
            empleado obj = new empleado(nom,suel);
            
            
            
            obj.imprimir();
            Console.ReadKey();
           
           
        }
    }
}
