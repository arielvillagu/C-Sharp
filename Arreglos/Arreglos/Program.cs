﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arreglo unidimensional

            /* int[] numero;

             numero = new int[5];

             numero[0] = 5;
             numero[2] = 6;
             numero[4] = 7;
             foreach(int elemento in numero)
             {
                 Console.WriteLine(elemento);
             }*/

            //Arreglo bidimensional
            int[,] numero;

            numero = new int[3, 3];

            for(int fila = 0; fila < 3; fila++)
            {
                for(int col = 0; col < 3; col++)
                {
                    Console.WriteLine("Dame un numero: ");
                    numero[fila, col] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.Clear();

            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(" " + numero[fila, col]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
