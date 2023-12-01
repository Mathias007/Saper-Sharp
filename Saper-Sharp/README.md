# Minesweeper in C#

A simple Minesweeper game implemented in C# with the use of classes. The game allows interactive gameplay in the terminal.

## Project Structure

The project is divided into three classes:
- **MinesweeperGame**: The main class handling the game logic, board initialization, and user interaction.
- **Board**: Responsible for initializing the bomb-laden board, counting bombs in the vicinity, and expanding empty areas.
- **Display**: Manages the display of the board in the terminal, user input retrieval, and board interaction.

## Getting Started

1. Run the project in a C# supporting environment (e.g., Visual Studio, Visual Studio Code).
2. Set the board dimensions and the number of bombs in the MinesweeperGame class in the `Program.cs` file.
3. Run the application and start playing!

## Game Rules

- Uncover board squares, avoiding bombs.
- Numbers on uncovered squares indicate the number of bombs in their vicinity.
- The game ends when you uncover a bomb (lose) or uncover all squares without bombs (win).

## Author

Author: Mateusz **Mathias** Stawowski

## License

This project is available under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
