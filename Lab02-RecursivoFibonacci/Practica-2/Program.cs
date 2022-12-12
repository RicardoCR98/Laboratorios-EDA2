using System;
using System.Diagnostics;
namespace Practica_2;
class Program{
    static void Main(string[] args){
        Stopwatch stopwatch1 = new Stopwatch();
        Stopwatch stopwatch2= new Stopwatch();
        int numeroTerminos;

        do {
		Console.WriteLine("Introduzca el numero de términos: ");
		numeroTerminos = Convert.ToInt32(Console.ReadLine());
	    }while (numeroTerminos <= 1);

        stopwatch1.Start(); // Iniciar medicion para el método recursivo
        Console.Write("Fibonacci Recursivo: ");
        for (int k = 0; k < numeroTerminos; k++){
		    Console.Write(fiboRecursivo(k) + " ");
	    }
        stopwatch1.Stop(); // Medicion detenida para metodo recursivo.
        Console.WriteLine(" ");
        Console.WriteLine("Tiempo para de metodo Recursivo: {0}", stopwatch1.Elapsed.ToString("ss\\.fffff"));
        Console.WriteLine(" ");

        stopwatch2.Start(); // Iniciar medicion para el método iterativo
        Console.Write("Fibonacci Iterativo: ");
        fiboIterativo(numeroTerminos);
        stopwatch2.Stop(); // Medicion detenida para metodo Iterativo.
        Console.WriteLine(" ");
        Console.WriteLine("Tiempo para de metodo Iterativo: {0}", stopwatch2.Elapsed.ToString("ss\\.fffff"));
        
    }

    static long fiboRecursivo(int n){
        if(n >= 2){
            return fiboRecursivo(n-2) + fiboRecursivo(n-1);
        }else{
            return n;
        }
    }

    static void fiboIterativo(int n){
        int n1=0, n2=1;
        Console.Write ("0 1 ");
       for(int i = 0; i<n-2; i++){
            n2 = n1 + n2;
            n1 = n2 - n1;
            Console.Write(n2 + " ");
        }
    }
}
