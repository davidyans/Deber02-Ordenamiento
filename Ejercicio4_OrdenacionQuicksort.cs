namespace ED_Deber02_Ordenamientos;
class Ejercicio4_OrdenacionQuicksort
{
    static void Main(string[] args)
    {
        float[] A = new float[20];
        fillArray(A);

        Console.WriteLine("\n\n\t\t ******** Arreglo desordenado: ******** ");
        printArray(A);
        Console.WriteLine();

        QuickSort(A, 0, A.Length-1);

        Console.WriteLine("\t\t ******** Arreglo Ordenado por Quicksort: ********");
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

    static void QuickSort(float[] a, int primero, int ultimo) {
        int i, j, central;
        float pivote;
        central = (primero + ultimo) / 2;
        pivote = a[central];
        i = primero;
        j = ultimo;
        do
        {
            while (a[i] < pivote) i++;
            while (a[j] > pivote) j--;
            if (i <= j)
            {
                float tmp;
                tmp = a[i];
                a[i] = a[j];
                a[j] = tmp; /* intercambia a[i] con a[j] */
                i++;
                j--;
            }
        } while (i <= j);
        if (primero < j)
            QuickSort(a, primero, j); /* mismo proceso con sublista izquierda */
        if (i < ultimo)
            QuickSort(a, i, ultimo); /* mismo proceso con sublista derecha */
    }
}