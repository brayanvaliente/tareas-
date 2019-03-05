using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    public class Class1 {

        String animal;
        int I;
        public void reptiles() {
            for (I = 0; I < 20; I++) {

                Console.WriteLine("ingrse animal");
                animal = Console.ReadLine();
                Console.WriteLine("El reptil es: " + " " + I + " " + animal);
                Console.ReadKey();
            }
        }
        public void aves() {
            for (I = 0; I < 10; I++) {

                Console.WriteLine("ingrse animal");
                animal = Console.ReadLine();
                Console.WriteLine("El aves es: " + " " + I + " " + animal);
                Console.ReadKey();
            }
        }
        public void mamiferos() {
            for (I = 0; I < 15; I++) {

                Console.WriteLine("ingrse animal");
                animal = Console.ReadLine();
                Console.WriteLine("El maiferos es: " + " " + I + " " + animal);
                Console.ReadKey();
            }
        }
    }
}
