/*
Programa que permita obtener el cubo, la cuarta y la 
quinta potencia de N números ingresados por el usuario.
*/

using System;

class ejer50
{
public static void Main(){
	
	int I=0,N;
	double acumulador=0,num;

	Console.WriteLine("ingrese cantidad de numeros: ");
	N=int.Parse(Console.ReadLine());
	
	while(I<=N){
		
		Console.WriteLine("ingres numero: ");
		num = int.Parse(Console.ReadLine());
		
		acumulador = acumulador+num;	
		I++;
	}
	Console.WriteLine("EL cubo: "+(Math.Pow(acumulador,3)));
	Console.WriteLine("La cuarta: "+(Math.Pow(acumulador,4)));
	Console.WriteLine("La quinta: "+(Math.Pow(acumulador,5)));
}
}