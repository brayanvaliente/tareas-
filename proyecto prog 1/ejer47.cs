/*
Programa que encuentre el resultado de la operación 
potencia donde el usuario ingresa el valor de la base y el exponente.

*/

using System;

class ejer47
{
public static void Main(){
	
	int a,b;
	
	
	while(true){
		
		Console.WriteLine("ingres base: ");
		a = int.Parse(Console.ReadLine());
		Console.WriteLine("ingres exponete: ");
		b = int.Parse(Console.ReadLine());
		Console.WriteLine("resultado: "+(Math.Pow(a,b)));	
	}
}
}