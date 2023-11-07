/*
EJEMPLO: Escribir en la consola posicionalmente
Codigo para mostrar una cuadricula con la consola, de manera posicional accediendo a posiciones fila, columna.
  */

using System;


    class Programa
    {
        static void Main()
        {
            for (int i = 1; i <= 8; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write(i);
                Console.SetCursorPosition(0, i);
                Console.Write(i);
            }

            for (int fila = 1; fila <= 8; fila++)
            {
                for (int columna = 1; columna <= 8; columna++)
                {
                    bool esCasillaNegra;

                    if (fila % 2 == 0)
                        esCasillaNegra = columna % 2 != 0;
                    else
                        esCasillaNegra = columna % 2 == 0;

                    if (esCasillaNegra)
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                    else
                        Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(columna, fila);
                    Console.Write(" ");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n");


        }
    }

