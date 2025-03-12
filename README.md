# DiceRollGameV2

## Project Overview

DiceRollGameV2 is a simple console-based dice rolling game where the player has to guess the number rolled by a virtual dice within a limited number of tries.

## Project Structure

The project consists of the following files and directories:

-   `Dice.cs`: Contains the `Dice` class, responsible for simulating a dice roll.
-   `DiceRollGameV2.csproj`: The project file for the .NET application.
-   `GameHandler.cs`: Contains the `GameHandler` class, which manages the game logic, user input, and result.
-   `GameResult.cs`: Defines the `GameResult` enum, representing the possible outcomes of the game (Win or Lose).
-   `Program.cs`: The main entry point of the application, which initializes the game and handles the game flow.
-   `bin/`: Directory containing the compiled executable (after building).
-   `obj/`: Directory containing intermediate build files.

## How to Play

1.  The game rolls a virtual dice, generating a random number between 1 and 6.
2.  The player is prompted to enter their guess.
3.  The player has 3 tries to guess the correct number.
4.  If the player guesses correctly, they win.
5.  If the player fails to guess correctly within 3 tries, they lose.

## Build and Run

1.  **Prerequisites:** Make sure you have the .NET 8.0 SDK installed on your system.
2.  **Build:** Open a terminal or command prompt in the project's root directory (`DiceRollGameV2/`) and run the following command to build the project:

    ```bash
    dotnet build
    ```
3. **Run** After a successful build, navigate to the `bin/Debug/net8.0` directory within the project directory. You may need to adjust the path based on your specific build configuration. Then, run the following command to start the game:

    ```bash
    dotnet DiceRollGameV2.dll
    ```
    Alternatively, you can run the project directly from the root directory using:
    ```
    dotnet run
