namespace ED_Deber02_Ordenamientos;

using System;
using System.Diagnostics;

class Ejercicio2_OrdenacionPorSeleccion_extra
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
        Seleccion(A, A.Length);
        String time_elapsed = " ---------------- Tiempo de ejecución: " + stopwatch.Elapsed + " ----------------";
        stopwatch.Stop();
        Console.WriteLine("\n");

        Console.WriteLine("\t\t ******** Arreglo Ordenado por Seleccion: ********");
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

    static void Seleccion(float[] A, int n)
    {
        int i, j, indiceMenor;
        float auxiliar;
        
        Console.WriteLine("");
        String ini = "Comienzo del algoritmo de selección:";
        Console.WriteLine(ini.PadRight(35) + "\t" + "Cambio".PadRight(9) + "Pasada");
        String ArregloString = ("");
    
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
            // Guardo dato para impresion
            String a = A[indiceMenor].ToString();
            // --------------------------
            A[indiceMenor] = A[i];
            // Guardo dato para impresion
            String b = A[i].ToString();
            // --------------------------
            A[i] = auxiliar;

            for (int k = 0; k < A.Length; k++)
            {
                ArregloString += A[k] + " ";
            }
            Console.WriteLine(ArregloString.PadRight(35) + "\t" + a.PadRight(3) + " " + b.PadRight(9) + (i).ToString());
            ArregloString = ("");
        }
    }

}
