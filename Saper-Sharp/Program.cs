using System;

class Program
{
    static void Main()
    {
        MinesweeperGame game = new MinesweeperGame(10, 10, 15);
        game.Play();
    }
}
