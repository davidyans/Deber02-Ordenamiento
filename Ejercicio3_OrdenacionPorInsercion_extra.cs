namespace ED_Deber02_Ordenamientos;

using System;
using System.Diagnostics;

class Ejercicio3_OrdenacionPorInsercion_extra
{
    static void Main1(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        float[] A = new float[10];
        fillArray(A);

        Console.WriteLine("\n\n\t\t ******** Arreglo desordenado: ******** ");
        printArray(A);
        Console.WriteLine();
        
        // -------------------------------------
        stopwatch.Start();
        // -------------------------------------
        Insercionlineal(A);
        String time_elapsed = " ---------------- Tiempo de ejecución: " + stopwatch.Elapsed + " ----------------";
        stopwatch.Stop();
        Console.WriteLine("\n");

        Console.WriteLine("\t\t ******** Arreglo Ordenado por insercion lineal: ********");
        printArray(A);
        Console.WriteLine();
        Console.WriteLine("\n" + time_elapsed);
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

    static void Insercionlineal(float[] A) {
        int i, j;
        bool encontrado;
        float auxiliar;

        Console.WriteLine("Comienzo del algoritmo de inserción lineal: ");

        for (i = 1; i < A.Length; i++)
        { // A[0], A[1], ..., A[i-1] está ordenado
            auxiliar = A[i];
            j = i - 1;
            encontrado = false;
            while ((j >= 0) && !encontrado)
            {
                if (A[j] > auxiliar)
                { // se mueve dato hacia la derecha para la inserción
                    A[j + 1] = A[j];
                    j--;
                }
                else
                {
                    encontrado = true;
                }
            }
            A[j + 1] = auxiliar;
            for(int k=0; k<A.Length; k++){
                Console.Write(A[k] + " ");
            }
            Console.WriteLine();
        }
    }
}