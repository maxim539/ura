using System;

class Krestik_S_Nolikom
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1; // 1 - X, 2 - O
    static bool gameOver = false;

    static void Main()
    {
        Console.WriteLine("Добро пожаловать в игру Крестики-нолики!");
        Console.WriteLine("Игрок 1: X, Игрок 2: O\n");
        
        while (!gameOver)
        {
            DrawBoard();
            PlayerMove();
            CheckGameStatus();
            SwitchPlayer();
        }
    }

    static void DrawBoard()
    {
        Console.Clear();
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {board[0]}  |  {board[1]}  |  {board[2]}  ");
        Console.WriteLine("___|_|___");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {board[3]}  |  {board[4]}  |  {board[5]}  ");
        Console.WriteLine("___|_|___");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {board[6]}  |  {board[7]}  |  {board[8]}  ");
        Console.WriteLine("     |     |     ");
    }

    static void PlayerMove()
    {
        bool validMove = false;
        int choice = 0;

        while (!validMove)
        {
            Console.Write($"Игрок {currentPlayer}, выберите клетку (1-9): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 9)
            {
                int index = choice - 1;
                if (board[index] != 'X' && board[index] != 'O')
                {
                    board[index] = (currentPlayer == 1) ? 'X' : 'O';
                    validMove = true;
                }
                else
                {
                    Console.WriteLine("Эта клетка уже занята! Попробуйте другую.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите число от 1 до 9.");
            }
        }
    }

    static void CheckGameStatus()
    {
        // Проверка горизонталей
        for (int i = 0; i < 9; i += 3)
        {
            if (board[i] == board[i+1] && board[i+1] == board[i+2])
            {
                GameWon();
                return;
            }
        }

        // Проверка вертикалей
        for (int i = 0; i < 3; i++)
        {
            if (board[i] == board[i+3] && board[i+3] == board[i+6])
            {
                GameWon();
                return;
            }
        }

        // Проверка диагоналей
        if ((board[0] == board[4] && board[4] == board[8]) ||
            (board[2] == board[4] && board[4] == board[6]))
        {
            GameWon();
            return;
        }

        // Проверка на ничью
        bool isDraw = true;
        foreach (char cell in board)
        {
            if (cell != 'X' && cell != 'O')
            {
                isDraw = false;
                break;
            }
        }

        if (isDraw)
        {
            DrawBoard();
            Console.WriteLine("Ничья! Игра окончена.");
            gameOver = true;
        }
    }

    static void GameWon()
    {
        DrawBoard();
        Console.WriteLine($"Игрок {currentPlayer} ({((currentPlayer == 1) ? 'X' : 'O')}) победил!");
        gameOver = true;
    }

    static void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 1) ? 2 : 1;
    }
}