namespace ED_Deber02_Ordenamientos;
class Ejercicio1_OrdenacionBurbuja
{
    static void Main1(string[] args)
    {
        float[] A = new float[20];
        fillArray(A);

        Console.WriteLine("\n\n\t\t ******** Arreglo desordenado: ******** ");
        printArray(A);
        Console.WriteLine();
        
        // -------------------------------------
        Burbuja(A, A.Length);        
        Console.WriteLine("\t\t ******** Arreglo Ordenado por Burbuja: ********");
        printArray(A);
        Console.WriteLine();
    }

    static void printArray(float[] A) {
        for(int i=0; i<A.Length; i++){
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
    }

    static void fillArray(float[] A) {
        Random random = new Random();
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = random.Next(1, 101);
        }
    }

    static void Burbuja(float[] a, int n)
    {
        int i, j;
        float auxiliar;

        for (i = 0; i < n-1; i++) {             //n–1 pasadas
            for (j=0; j < n - 1 - i; j++) { // burbujeo de datos
                if (a[j] > a[j + 1]) {          //comparación de elementos contiguos para intercambio
                    auxiliar = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = auxiliar;
                }
            }
        }
    }
}
