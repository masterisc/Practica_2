using System;
using System.Threading;


namespace Practica2
{ 
	class Program 
	{ 
		static void Main(string[] args) 
		{
			Console.Title = "Practica2"; 
		
			int hora,minuto,segundo; 
			 
			Console.WriteLine("Programa muestra cronometro y reloj \n\n Selecciona una opcion: \n"); 
			Console.WriteLine("1= Cronometro\n2= Reloj\n"); 

			int opc = int.Parse(Console.ReadLine()); 

			switch (opc) { 
			
			case 1: 
					for (hora=0; hora<60; hora++)
						for (minuto=0; minuto<60; minuto++)
							for (segundo=0; segundo<60; segundo++) {
								Console.Clear ();
								Console.WriteLine ("Cronometro: \n");
								Console.WriteLine (" " + hora + ":" + minuto + ":" + segundo); 
								Thread.Sleep (1000);
								}

			break;

			case 2:
				do {
					Console.Clear ();
					Console.WriteLine ("Reloj: \n"); 
					DateTime fecha = DateTime.Now;
					Console.Write (fecha.Hour + ":" + fecha.Minute + ":" + fecha.Second); 
					Thread.Sleep (1000);
				} while(true);

			 break; 

			} 

			Console.ReadKey(true);
		} 
	} 
}