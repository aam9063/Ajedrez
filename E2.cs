/*
EJEMPLO ESCRIBIR POSICIONALMENTE DESPUES DE DIBUJAR EL TABLERO
Escribimos en la posicion 3,3 despues de dibujar el tablero
*/

using System;


class Programa
{
    static void Main()
    {
        Console.Clear();

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

        Console.SetCursorPosition(3, 3);
        Console.Write("*");


        Console.Read();


    }

}
