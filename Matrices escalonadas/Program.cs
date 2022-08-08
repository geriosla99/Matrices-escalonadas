using System;

namespace Matrices_escalonadas
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo[][] nombre = new tipo [filas][];

            //int[] numeros = new int[4] { 23, 13, 5, 6 };
            int i;
            int j;
            //Mostramos cuántos  elementos tiene la matriz unidimensional
            //Console.WriteLine(numeros.length);

            double[][] ventas = new double[4][] { new double[] { 100, 120, 205 }, 
                                                    new double[]  { 115, 196, 300 }, 
                                                    new double[]  { 157, 172, 245 },
                                                    new double[]  { 130, 180, 281 } };
            //Console.WriteLine(ventas2D.Length);

            for(i=0; i < ventas.Length; i++)
            {
                Console.WriteLine("Elemento {0}", i);
                for(j=0; j<ventas[i].Length; j++)
                {
                    Console.WriteLine(ventas[i][j]);
                }
            }

        }
    }
}
