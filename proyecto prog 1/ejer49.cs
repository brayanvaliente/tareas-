/*Programa que reciba un listado de N números ingresados
 por el usuario y luego determine el número mayor y el
 número menor de entre todos los datos ingresados.*/
 
using System;

class ejer49{
public static void Main(){
	
	int N,I=1,may=0,men=9999,num=0;
	
	Console.WriteLine("ingrese la cantidad de numeros");
	N= int.Parse(Console.ReadLine());
	
	while(I<=N){
		Console.WriteLine("ingrese numeros ");
		num= int.Parse(Console.ReadLine());
		
		if(men>= num){
			men=num;
		}
		
		if(may<= num){
			may=num;
		}
		
		
		
		I++;
	}
	
	Console.WriteLine("numero mayor es : "+may);
	Console.WriteLine("numero menor es : "+men);
}
}

