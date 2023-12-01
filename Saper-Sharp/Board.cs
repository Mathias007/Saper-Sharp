using System;

class Board
{
    public static char[,] InitializeBoard(int width, int height, int bombCount)
    {
        char[,] board = new char[height, width];
        Random random = new Random();

        // Wypełnij planszę bombami.
        for (int i = 0; i < bombCount; i++)
        {
            int x, y;
            do
            {
                x = random.Next(0, width);
                y = random.Next(0, height);
            } while (board[y, x] == '*');

            board[y, x] = '*';
        }

        // Zainicjalizuj resztę planszy.
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (board[i, j] != '*')
                {
                    int count = CountAdjacentBombs(board, j, i);
                    board[i, j] = count.ToString()[0];
                }
            }
        }

        return board;
    }

    public static int CountAdjacentBombs(char[,] board, int x, int y)
    {
        int count = 0;
        int height = board.GetLength(0);
        int width = board.GetLength(1);

        for (int i = Math.Max(0, y - 1); i <= Math.Min(height - 1, y + 1); i++)
        {
            for (int j = Math.Max(0, x - 1); j <= Math.Min(width - 1, x + 1); j++)
            {
                if (board[i, j] == '*')
                {
                    count++;
                }
            }
        }

        return count;
    }

    public static void ExpandZeros(char[,] board, char[,] displayBoard, int x, int y)
    {
        int height = board.GetLength(0);
        int width = board.GetLength(1);

        for (int i = Math.Max(0, y - 1); i <= Math.Min(height - 1, y + 1); i++)
        {
            for (int j = Math.Max(0, x - 1); j <= Math.Min(width - 1, x + 1); j++)
            {
                if (displayBoard[i, j] == ' ' && board[i, j] != '*')
                {
                    displayBoard[i, j] = CountAdjacentBombs(board, j, i).ToString()[0];

                    if (displayBoard[i, j] == '0')
                    {
                        ExpandZeros(board, displayBoard, j, i);
                    }
                }
            }
        }
    }

    public static bool CheckWin(char[,] displayBoard, int bombCount)
    {
        int uncoveredCount = 0;
        int width = displayBoard.GetLength(1);
        int height = displayBoard.GetLength(0);

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (displayBoard[i, j] != ' ' && displayBoard[i, j] != '*')
                {
                    uncoveredCount++;
                }
            }
        }

        return uncoveredCount == (width * height) - bombCount;
    }
}
