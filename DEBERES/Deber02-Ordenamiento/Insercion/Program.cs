namespace Insercion;
using System.Diagnostics;
class Program{
    static void Main(string[] args){
       Stopwatch stopwatch1 = new Stopwatch();
        stopwatch1.Start();
        Console.Write("Arreglo Desordenado: ");
        
        int[] A = {14, 9, 16, 1, 13, 17};

        for(int i = 0; i<A.Length; i++){
            Console.Write(A[i] + " ");
        }
        Console.WriteLine("");
        Console.WriteLine("Comienza ordenación por inserccion: ");
        inserccionLineal(A);
        Console.WriteLine("Arreglo Ordenado por inserccion lineal: ");
        for(int i = 0; i<A.Length; i++){
            Console.Write(A[i] + " ");
        }
        stopwatch1.Stop();
        Console.WriteLine(" ");
        Console.WriteLine("Tiempo transcurrido: {0}", stopwatch1.Elapsed.ToString("ss\\.fffff")); 
    }    
    static void inserccionLineal(int[] A){
    int i, j;
    bool encontrado;
    int auxiliar;
    for (i = 1; i < A.Length; i++){ // A[0], A[1], ..., A[i-1] está ordenado
        auxiliar = A[i];
        j = i - 1;
        encontrado = false;
        while ((j >= 0) && !encontrado)
        {
            if (A[j] > auxiliar){ // se mueve dato hacia la derecha para la inserción
                A[j + 1] = A[j];
                j--;
            }else{
                encontrado = true;
            }
        }
        A[j + 1] = auxiliar;
        for (int k = 0; k < A.Length; k++){
            Console.Write(A[k] + " ");
        }
        Console.WriteLine(" ");
    }
    }   
}
