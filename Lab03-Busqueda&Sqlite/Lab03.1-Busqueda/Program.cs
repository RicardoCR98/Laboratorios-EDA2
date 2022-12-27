namespace Lab03._1_Busqueda;
using System.Diagnostics;
class Program
{
    static void Main(string[] args){
        Stopwatch stopwatch1 = new Stopwatch();
        stopwatch1.Start();
    int[] A = { -8, 4, 5, 9, 12, 18, 25, 40, 60 };

    Console.WriteLine("Arreglo desordenado: ");
    for (int i = 0; i < A.Length; i++){
        Console.WriteLine($"A[{i}]={A[i]}");     
    }
    
    int posicionEncontrada = busquedaBinaria(A,A.Length, 40);
    Console.WriteLine(" ");
    Console.WriteLine("Elemento encontrado en la posición: "+ posicionEncontrada);
    stopwatch1.Stop();

    Console.WriteLine("Tiempo de ejecución: {0}", stopwatch1.Elapsed.ToString("ss\\.fffff"));
    Console.WriteLine("Hora de inicio del programa: {0}", DateTime.Now.ToString("hh:mm:fffff"));
    Console.WriteLine("Hora de fin del programa: {0}", DateTime.Now.ToString("hh:mm:fffff"));
    }

    static int busquedaBinaria(int[] lista, int n, int clave){
    int central = 0, bajo = 0, alto = n - 1;
    int valorCentral;
    while (bajo <= alto)
    {
        central = (bajo + alto) / 2;
        /* indice de elemento central */
        valorCentral = lista[central];
        /* valor del indice central */
        if (lista[central] == clave)
            return central; /* encontrado, devuelve posicion */
        else if (clave < lista[central])
            alto = central - 1; /* ir a sublista inferior */
        else
            bajo = central + 1; /* ir a sublista superior */
    }
    return -1;
    /* elemento no encontrado */
}
}
