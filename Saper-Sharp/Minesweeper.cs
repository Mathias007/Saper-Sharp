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

            int[] coordinates = Display.GetUserInput();

            int x = coordinates[0];
            int y = coordinates[1];

            if (x >= 0 && x < width && y >= 0 && y < height && displayBoard[y, x] == ' ')
            {
                if (board[y, x] == '*')
                {
                    Console.WriteLine("Boom! Koniec gry.");
                    gameOver = true;
                }
                else
                {
                    int count = Board.CountAdjacentBombs(board, x, y);
                    displayBoard[y, x] = count.ToString()[0];

                    if (count == 0)
                    {
                        Board.ExpandZeros(board, displayBoard, x, y);
                    }

                    if (Board.CheckWin(displayBoard, bombCount))
                    {
                        Console.WriteLine("Gratulacje! Wygrałeś!");
                        gameOver = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowe współrzędne. Spróbuj ponownie.");
            }
        }
    }
}
