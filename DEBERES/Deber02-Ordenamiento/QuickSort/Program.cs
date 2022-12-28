namespace QuickSort;
using System.Diagnostics;
class Program{
    static void Main(string[] args){
        Stopwatch stopwatch1 = new Stopwatch();
        stopwatch1.Start();
        Console.Write("Arreglo Desordenado: ");
        
        int[] A = {79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24};

        for(int i = 0; i<A.Length; i++){
            Console.Write(A[i] + " ");
        }
        Console.WriteLine("");


        quickSort(A,0, A.Length-1);
        Console.WriteLine("Arreglo Ordenado por QuickSort: ");
        for(int i = 0; i<A.Length; i++){
            Console.Write(A[i] + " ");
        }
        stopwatch1.Stop();
        Console.WriteLine(" ");
        Console.WriteLine("Tiempo transcurrido: {0}", stopwatch1.Elapsed.ToString("ss\\.fffff")); 
    }

    static void quickSort(int[] A, int primero, int ultimo){
        int i, j, central;
        int pivote;
        central = (primero + ultimo) / 2;
        pivote = A[central];
        i = primero;
        j = ultimo;
        do
        {
            while (A[i] < pivote) i++;
            while (A[j] > pivote) j--;
            if (i <= j)
            {
                int tmp;
                tmp = A[i];
                A[i] = A[j];
                A[j] = tmp; /* intercambia a[i] con a[j] */
                i++;
                j--;
            }
        } while (i <= j);
        if (primero < j)
            quickSort(A, primero, j); /* mismo proceso con sublista izquierda */
        if (i < ultimo)
            quickSort(A, i, ultimo); /* mismo proceso con sublista derecha */
        }
}
