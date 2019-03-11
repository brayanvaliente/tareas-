/*Programa que calcule la suma de los N primeros números naturales, donde N es un número  digitado por el usuario.*/	


using System;

class ejer48
{
public static void Main(){
	
	int N,I=1,acumulador=0;
	Console.WriteLine("ingrese la cantidad de numeros a sumar:  ");
	N= int.Parse(Console.ReadLine());
	
	while(I<=N){
		acumulador=acumulador+I;
		
		I++;
	}
	Console.WriteLine("Su suma es: "+acumulador);
}
}