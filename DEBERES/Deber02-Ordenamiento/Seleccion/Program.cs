namespace Seleccion;
using System.Diagnostics;
class Program{
    static void Main(string[] args){
        Stopwatch stopwatch1 = new Stopwatch();
        stopwatch1.Start();
        Console.Write("Arreglo Desordenado: ");
        
        int[] A = {51, 21, 39, 80, 36};

        for(int i = 0; i<A.Length; i++){
            Console.Write(A[i] + " ");
        }
        Console.WriteLine(" ");
        SeleccionDibujada(A);
        Console.Write("Arreglo Ordenado: ");
        Seleccion(A);
        stopwatch1.Stop();
        Console.WriteLine(" ");
        Console.WriteLine("Tiempo transcurrido: {0}", stopwatch1.Elapsed.ToString("ss\\.fffff"));
    }

    static void Seleccion(int[] A){
    int i, j, indiceMenor;
    int auxiliar;
    for (i = 0; i < A.Length - 1; i++){
        indiceMenor = i; // posición del menor
        for (j = i + 1; j < A.Length; j++){
            if (A[j] < A[indiceMenor]){
                indiceMenor = j; // nueva posición del menor
            }
        }
        auxiliar = A[indiceMenor]; // intercambia posiciones
        A[indiceMenor] = A[i];
        A[i] = auxiliar;
    }

    for(int k = 0; k<A.Length; k++){
        Console.Write(A[k]+ " ");
    }
    }

    static void SeleccionDibujada(int[] A){
    int i, j, indiceMenor;
    int auxiliar;
    Console.Write("Comienzo de la burbuja: "+ "\tcambio"+ "\t\tPasada"+ "\n");
    for (i = 0; i < A.Length - 1; i++){
        indiceMenor = i; // posición del menor
        for (j = i + 1; j < A.Length; j++){
            if (A[j] < A[indiceMenor]){
                indiceMenor = j; // nueva posición del menor
            }
        }
        auxiliar = A[indiceMenor]; // intercambia posiciones
        A[indiceMenor] = A[i];
        A[i] = auxiliar;
        
        for(int k = 0; k<A.Length; k++){
            Console.Write(A[k] + " ");    
        }
        Console.WriteLine("\t\t\t"+A[i]+" -> "+A[indiceMenor] + "\t  "+ i);
    }
    }
}
