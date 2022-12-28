namespace Burbuja;
using System.Diagnostics;
class Program{
    static void Main(string[] args){
        Stopwatch stopwatch1 = new Stopwatch();
        stopwatch1.Start();
        Console.Write("Arreglo Desordenado: ");
        
        int[] A = {50, 20, 40, 80, 30};

        for(int i = 0; i<A.Length; i++){
            Console.Write(A[i] + " ");
        }
        Console.WriteLine(" ");
        BurbujaDibujada(A);
        Console.WriteLine("Arreglo Ordenado: ");
        Burbuja(A);
        stopwatch1.Stop();
        Console.WriteLine(" ");
        Console.WriteLine("Tiempo transcurrido: {0}", stopwatch1.Elapsed.ToString("ss\\.fffff"));
    }
    static void Burbuja(int[] A){
        int aux;
        for(int i = 0; i<A.Length-1; i++){
            for(int j = 0; j<A.Length -1-i;j++){
                if(A[j] > A[j+1]){
                    aux = A[j];
                    A[j] = A[j+1];
                    A[j+1] = aux;
                }   
            }
        }

        for(int k = 0; k<A.Length; k++){
            Console.Write(A[k]+ " ");
        }
    }

    static void BurbujaDibujada(int[] A){
        int aux;
        Console.Write("Comienzo de la burbuja: "+ "\tcambio"+ "\t\tPasada"+ "\n");
        for(int i = 0; i<A.Length-1; i++){
            for(int j = 0; j<A.Length -1-i;j++){
                if(A[j] > A[j+1]){
                    aux = A[j];
                    A[j] = A[j+1];
                    A[j+1] = aux;
                }   
                for(int k = 0; k<A.Length; k++){
                    Console.Write(A[k] + " ");    
                }
                Console.WriteLine("\t\t\t"+A[j]+" -> "+A[j+1] + "\t  "+ i);
            }
            
        }
    }
}