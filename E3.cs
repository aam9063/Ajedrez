/*
EJEMPLO: Escribimos Lineas y Diagonales sobre un tablero
Usando funciones dibujamos las lineas izquierda-derecha, inferiores-superiores y las dos diagonales, sobre le tablero de ajedrez
*/

using System;

class Programa
{
    const int MAX_COLUMNAS = 8;

    static void Cabecera()
    {
        for (int i = 1; i <= 8; i++)
        {
            Console.SetCursorPosition(i, 0);
            Console.Write(i);
            Console.SetCursorPosition(0, i);
            Console.Write(i);
        }
    }
    static void DibujaTablero()

    {
        for (int fila = 1; fila <= MAX_COLUMNAS; fila++)
        {
            for (int columna = 1; columna <= MAX_COLUMNAS; columna++)
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

    }


    static void SoloLinea(int fila, int columna, string linea)
    {
        Console.SetCursorPosition(columna, fila);

        switch (linea)
        {
            case "DIAGONAL DERECHA":
                if (fila == columna)
                    Console.Write("*");
                break;

            case "DIAGONAL IZQUIERDA":
                if ((fila + columna) == MAX_COLUMNAS + 1)
                    Console.Write("*");
                break;

            case "LINEA IZQUIERDA":
                if (columna == 1)
                    Console.Write("*");
                break;
            case "LINEA DERECHA":
                if (columna == MAX_COLUMNAS)
                    Console.Write("*");
                break;
            case "LINEA SUPERIOR":
                if (fila == 1)
                    Console.Write("*");
                break;
            case "LINEA INFERIOR":
                if (fila == MAX_COLUMNAS)
                    Console.Write("*");
                break;

        }

    }


    static void DibujaLinea(string linea)

    {
        for (int fila = 1; fila <= MAX_COLUMNAS; fila++)
        {
            for (int columna = 1; columna <= MAX_COLUMNAS; columna++)
                SoloLinea(fila, columna, linea);
        }
        Console.BackgroundColor = ConsoleColor.Black;
    }

    static void Main()
    {
        Console.Clear();

        Cabecera();
        DibujaTablero();
        DibujaLinea("DIAGONAL DERECHA");
        DibujaLinea("DIAGONAL IZQUIERDA");
        DibujaLinea("LINEA IZQUIERDA");
        DibujaLinea("LINEA DERECHA");
        DibujaLinea("LINEA SUPERIOR");
        DibujaLinea("LINEA INFERIOR");
       


        Console.Read();


    }
}
