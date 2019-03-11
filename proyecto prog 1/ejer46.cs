/*Programa que permita determinar si un estudiante que recibe 15 notas gana o no 
la materia de Programación De Software. Se gana la materia si el promedio es mayor o igual a 4.0*/

using System;

class ejer46
{
public static void Main(){
	
	int I;
	double notas,prom=0,contador=0;
	
	
	for (I=1;I<16;I++){
		Console.WriteLine("ingrese las notas: ");
		notas = double.Parse(Console.ReadLine());
		contador=contador+notas;
		prom = contador /I;
		
	}
	if(prom>=4){
		Console.WriteLine("SE gano la materia de Programación De Software : ");
	}
	else{
		Console.WriteLine("NO gano la materia de Programación De Software : ");
	}
}
}