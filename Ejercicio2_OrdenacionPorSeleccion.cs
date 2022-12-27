namespace ED_Deber02_Ordenamientos;
class Ejercicio2_OrdenacionPorSeleccion
{
    static void Main1(string[] args)
    {
        float[] A = new float[20];
        fillArray(A);

        Console.WriteLine("\n\n\t\t ******** Arreglo desordenado: ******** ");
        printArray(A);
        Console.WriteLine();
        // -----------------------
        Seleccion(A, A.Length);
        Console.WriteLine("\t\t ******** Arreglo Ordenado por Seleccion: ********");
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

    static void Seleccion(float[] A, int n)
    {
        int i, j, indiceMenor;
        float auxiliar;
        for (i = 0; i < n - 1; i++)
        {
            indiceMenor = i; // posición del menor
            for (j = i + 1; j < n; j++)
            {
                if (A[j] < A[indiceMenor])
                {
                    indiceMenor = j; // nueva posición del menor
                }
            }
            auxiliar = A[indiceMenor]; // intercambia posiciones
            A[indiceMenor] = A[i];
            A[i] = auxiliar;
        }
    }

}
