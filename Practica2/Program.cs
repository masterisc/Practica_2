using System;

namespace Practica1 
{ 
	class Program 
	{ 
		static void Main(string[] args) 
		{
			Console.Title = "Practica2"; 
		
			int primero, segundo; 
			 
			Console.WriteLine("Programa muestra cronometro y reloj \n\n Selecciona una opcion: \n"); 
			Console.WriteLine("1= cronometro\n2= Reloj\n"); 

			int opc = int.Parse(Console.ReadLine()); 

			switch (opc) { 

			case 1: 
				Console.WriteLine ("Cronometro: \n"); 

			break;

			case 2: 

				Console.WriteLine("Reloj: \n"); 
				Console.Write("\t Dame el primer numero: "); 
			
			break; 

			} 

			Console.ReadKey(true);
		} 
	} 
}