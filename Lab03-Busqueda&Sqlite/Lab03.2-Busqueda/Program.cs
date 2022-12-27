namespace Lab03._2_Busqueda;
using System.Linq;
using System.Collections;
class Program
{
    static void Main(string[] args){
        double flag =0;
        double flag2 = 0;
        Console.WriteLine("Generación de Números aleatorios");
        
        int[] arr = new int [100];
        int[] ale = randomArr(arr,100);

        Console.WriteLine(" ");
        
        for(int k =1; k<=50; k++){
            int randd = random();
            if(BusquedaLinealID(ale,randd) != -1){
                Console.WriteLine(k+". Elemento "+ randd +" es encontrado en la posición: " + BusquedaLinealID(ale,randd));
                flag++;
            }else{
                Console.WriteLine(k+". Elemento "+ randd +" NO se encuentra en el arreglo");
                flag2++;
            }
        }
        
        Console.WriteLine("");
        Console.WriteLine("Numero de busquedas con exito: "+ flag);
        Console.WriteLine("Numero de busquedas fallidas: "+ flag2);

        Console.WriteLine("Porcentaje de exito: "+ porcentaje(flag)+"%");
        Console.WriteLine("Porcentaje de fallo: "+ porcentaje(flag2)+"%");

        Console.WriteLine("Arreglo Ordenado");
        ordenar(ale);

    }

    static int BusquedaLinealID(int[] Arr, int clave){
    int i;
        for (i = 0; i < Arr.Length; i++)
            if (Arr[i] == clave)
                return i;
        return -1;      
    }

    static int[] randomArr(int[] arr, int n){
        var rand = new Random();
        for (int i = 0; i < n; i++){
            arr[i] = rand.Next (0,200);
        }
        
        for(int j = 0; j<arr.Length; j++){
            Console.WriteLine("arr["+j+"] = "+ arr[j]);
        }
        return arr;
    }
    static double porcentaje(double x){
        return (x/50)*100;
    }

    static int random(){
        Random rand = new Random();
        int rand_num = rand.Next(50);
        return rand_num;
    }
    
    static void ordenar(int[] arr){
        
        for(int i=1; i<arr.Length; i++){
            for(int k =0; k<arr.Length-i; k++){
                if(arr[k]<arr[k+1]){
                    int aux;
                    aux = arr[k];
                    arr[k] = arr[k+1];
                    arr[k+1] = aux;
                }
            }
        }
        for(int j = 0; j<arr.Length; j++){
            Console.Write(arr[j] + " ");
        }
    }
}
