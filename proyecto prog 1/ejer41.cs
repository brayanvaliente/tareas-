using System;

class ejer41
{
public static void Main(){
	
	int I , edad, acumulador=0;
	 
	for (I=1;I<15;I++){
		Console.WriteLine("ingrese la edad de los estudiantes ");
		edad = int.Parse(Console.ReadLine());
		
		acumulador = acumulador + edad;
		Console.WriteLine("el promedio de la edad es: "+(acumulador/I));
		
	}
	
	
}
}