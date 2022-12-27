namespace Lab03_Busqueda;
using System.Diagnostics;
class Program
{
    static void Main(string[] args){
        Stopwatch stopwatch1 = new Stopwatch();
        stopwatch1.Start();
        Console.WriteLine("Algoritmo de busqueda lineal");
        int[] A = {79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 13, 21, 17, 45, 80, 23, 75, 34};

        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < A.Length; i++){
        Console.WriteLine($"A[{i}]={A[i]}");     
        }

        int posicionEncontrada = BusquedaLinealID(A, 65); // 65 es el elemento a buscar
        Console.WriteLine(" ");
        Console.WriteLine("Elemento encontrado en la posición: "+ posicionEncontrada);
        stopwatch1.Stop();

        Console.WriteLine("Tiempo de ejecución: {0}", stopwatch1.Elapsed.ToString("ss\\.fffff"));
        Console.WriteLine("Hora de inicio del programa: {0}", DateTime.Now.ToString("hh:mm:fffff"));
        Console.WriteLine("Hora de fin del programa: {0}", DateTime.Now.ToString("hh:mm:fffff"));
    }

    static int BusquedaLinealID(int[] Arr, int clave){
    int i;
        for (i = 0; i < Arr.Length; i++)
            if (Arr[i] == clave)
                return i;
        return -1;      
    }
}
