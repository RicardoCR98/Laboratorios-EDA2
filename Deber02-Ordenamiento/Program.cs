namespace Deber02_Ordenamiento;
class Program{
    static void Main(string[] args){

        Console.Write("Arreglo Desordenado: ");
        
        int[] A = {50, 20, 40, 80, 30};

        for(int i = 0; i<A.Length; i++){
            Console.Write(A[i] + " ");
        }
        Console.WriteLine(" ");
        Burbuja(A);

    }
    static void Burbuja(int[] A){
        int aux;

        Console.WriteLine("Comienzo de la burbuja: ");
        for(int i = 0; i<A.Length-1; i++){
            
            for(int j = 0; j<A.Length -1-i;j++){
                if(A[j] > A[j+1]){
                    aux = A[j];
                    A[j] = A[j+1];
                    A[j+1] = aux;
                }    

                for(int k = 0; k<A.Length; k++){
                    for(int l = 0; l<A.Length ; l++){
                        Console.Write(A[k]+ " ");
                    }
                    Console.WriteLine(" ");
                }
        }

         
        }
    }
}
