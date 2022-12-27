namespace ED_Deber02_Ordenamientos;

using System;
using System.Diagnostics;

class Ejercicio1_OrdenacionBurbuja_extra
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
        Burbuja(A, A.Length);    
        String time_elapsed = " ---------------- Tiempo de ejecución: " + stopwatch.Elapsed + " ----------------";
        stopwatch.Stop();
        Console.WriteLine("\n");

        Console.WriteLine("\t\t ******** Arreglo Ordenado por Burbuja: ********");
        printArray(A);
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

    static void Burbuja(float[] A, int n)
    {
        Console.WriteLine("");
        String ini = "Comienzo del algoritmo de Burbuja:";
        Console.WriteLine(ini.PadRight(35) + "\t" + "Cambio".PadRight(9) + "Pasada");
        int i, j;
        float auxiliar;
        String ArregloString = ("");

        for (i = 0; i < n-1; i++) {             //n–1 pasadas
            for (j=0; j < n - 1 - i; j++) { // burbujeo de datos

                if (A[j] > A[j + 1]) {          //comparación de elementos contiguos para intercambio
                    auxiliar = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = auxiliar;

                    
                }
                for (int k = 0; k < A.Length; k++)
                {
                    ArregloString += A[k] + " ";
                }
                Console.WriteLine(ArregloString.PadRight(35) + "\t" + A[j].ToString().PadRight(3) + " " + A[j + 1].ToString().PadRight(9) + (i).ToString());
                ArregloString = ("");
            }
        }
    }
}