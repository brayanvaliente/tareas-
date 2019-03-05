using ConsoleApplication2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program {
    public static void Main(string[] args) {
        Class1 obj = new Class1();

        obj.reptiles();
        obj.aves();
        obj.mamiferos();

        Console.ReadKey();

    }
}

