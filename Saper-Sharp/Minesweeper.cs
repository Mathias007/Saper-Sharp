using System;

class MinesweeperGame
{
    private int width;
    private int height;
    private int bombCount;
    private char[,] board;
    private char[,] displayBoard;
    private bool gameOver;

    public MinesweeperGame(int width, int height, int bombCount)
    {
        this.width = width;
        this.height = height;
        this.bombCount = bombCount;
        board = Board.InitializeBoard(width, height, bombCount);
        displayBoard = Display.InitializeDisplayBoard(width, height);
        gameOver = false;
    }

    public void Play()
    {
        while (!gameOver)
        {
            Display.DisplayBoard(displayBoard);

            Console.WriteLine("Podaj współrzędne (x, y) do odkrycia (np. 2 3): ");
            string[] input = Console.ReadLine().Split(' ');

            // Reszta kodu do obsługi gry...
        }
    }

    // Reszta kodu klasy MinesweeperGame...
}
