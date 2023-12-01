using System;

class Display
{
    public static char[,] InitializeDisplayBoard(int width, int height)
    {
        char[,] displayBoard = new char[height, width];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                displayBoard[i, j] = ' ';
            }
        }

        return displayBoard;
    }

    public static void DisplayBoard(char[,] board)
    {
        Console.Clear();
        int height = board.GetLength(0);
        int width = board.GetLength(1);

        Console.WriteLine("Plansza Saper:");
        Console.Write("  ");

        for (int i = 0; i < width; i++)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine();

        for (int i = 0; i < height; i++)
        {
            Console.Write($"{i} ");
            for (int j = 0; j < width; j++)
            {
                Console.Write($"{board[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public static int[] GetUserInput()
    {
        Console.WriteLine("Podaj współrzędne (x, y) do odkrycia (np. 2 3): ");
        string[] input = Console.ReadLine().Split(' ');

        int[] coordinates = new int[2];

        if (input.Length == 2 && int.TryParse(input[0], out coordinates[0]) && int.TryParse(input[1], out coordinates[1]))
        {
            return coordinates;
        }
        else
        {
            Console.WriteLine("Nieprawidłowe dane wejściowe. Spróbuj ponownie.");
            return GetUserInput();
        }
    }
}
