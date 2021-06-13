using System;

namespace TicTacToeChallenge
{
    class Program
    {
        //create a tic tac toe board using switch, and multidimensional arrays. ask for player choice and cycle through array until choice is found
        //and change chosen number to either x or o. after game is over and someone won or tied ask if they want to play again.

        public static void AskPlayerOne()
        {
            if (counter < 9)
            {
                Console.Write("Player one please choose a square: ");
                string userInput = Console.ReadLine();
                isPlayerOne = true;
                bool isChoosable = false;

                for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < ticTacToeBoard.GetLength(1); j++)
                    {

                        if (userInput == ticTacToeBoard[i, j])
                        {
                            isChoosable = true;
                        }

                    }
                }
                if (isChoosable)
                {
                    ChooseSpot(userInput);
                }
                else
                {
                    Console.WriteLine("I am sorry you made an incorrect choice or the option you chose has already been chosen. Please" +
                        "try again.");
                    AskPlayerOne();
                }
            }
        }
        public static void AskPlayerTwo()
        {
            if (counter < 9)
            {
                Console.Write("Player two please choose a square: ");
                string userInput = Console.ReadLine();
                isPlayerOne = false;
                bool isChoosable = false;

                for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < ticTacToeBoard.GetLength(1); j++)
                    {

                        if (userInput == ticTacToeBoard[i, j])
                        {
                            isChoosable = true;
                        }

                    }
                }
                if (isChoosable)
                {
                    ChooseSpot(userInput);
                }
                else
                {
                    Console.WriteLine("I am sorry you made an incorrect choice or the option you chose has already been chosen. Please" +
                        "try again.");
                    AskPlayerOne();
                }
            }
        }
        public static void PlayAgain()
        {
            Console.WriteLine("(called PlayAgain function)Would you like to play again?");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "y")
            {
                Console.Clear();
                counter = 0;
                Main();
            }
            else if (userInput.ToLower() == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("I am sorry you entered an invalid answer.");
                PlayAgain();
            }
        }
        public static void PrintBoard()
        {
            Console.Clear();
            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ticTacToeBoard.GetLength(1); j++)
                {


                    Console.Write(ticTacToeBoard[i, j]);

                }
            }
        }
        public static void CheckIfWon(string[,] board)
        {
            //accross top 
            if (ticTacToeBoard[1, 1].Equals("X") && ticTacToeBoard[1, 4].Equals("X") && ticTacToeBoard[1, 7].Equals("X") ||
                ticTacToeBoard[1, 1].Equals("O") && ticTacToeBoard[1, 4].Equals("O") && ticTacToeBoard[1, 7].Equals("O"))
            {
                if (ticTacToeBoard[1, 1] == "X")
                {
                    Console.WriteLine("Congratulations player One! You have won the game.");
                    PlayAgain();
                }
                else if (ticTacToeBoard[1, 1] == "O")
                {
                    Console.WriteLine("Congratulations player Two! You have won the game.");
                    PlayAgain();
                }
            }//accross middle
            else if (ticTacToeBoard[4, 1].Equals("X") && ticTacToeBoard[4, 4].Equals("X") && ticTacToeBoard[4, 7].Equals("X") ||
                ticTacToeBoard[4, 1].Equals("O") && ticTacToeBoard[4, 5].Equals("O") && ticTacToeBoard[4, 8].Equals("O"))
            {
                if (ticTacToeBoard[4, 1] == "X")
                {
                    Console.WriteLine("Congratulations player One! You have won the game.");
                    PlayAgain();
                }
                else if (ticTacToeBoard[4, 1] == "O")
                {
                    Console.WriteLine("Congratulations player Two! You have won the game.");
                    PlayAgain();
                }
            }//accross bottom
            else if (ticTacToeBoard[7, 1].Equals("X") && ticTacToeBoard[7, 4].Equals("X") && ticTacToeBoard[7, 7].Equals("X") ||
                ticTacToeBoard[7, 1].Equals("O") && ticTacToeBoard[7, 4].Equals("O") && ticTacToeBoard[7, 7].Equals("O"))
            {
                if (ticTacToeBoard[7, 1] == "X")
                {
                    Console.WriteLine("Congratulations player One! You have won the game.");
                    PlayAgain();
                }
                else if (ticTacToeBoard[7, 1] == "O")
                {
                    Console.WriteLine("Congratulations player Two! You have won the game.");
                    PlayAgain();
                }
            }//down left
            else if (ticTacToeBoard[1, 1].Equals("X") && ticTacToeBoard[4, 1].Equals("X") && ticTacToeBoard[7, 1].Equals("X") ||
                ticTacToeBoard[1, 1].Equals("O") && ticTacToeBoard[4, 1].Equals("O") && ticTacToeBoard[7, 1].Equals("O"))
            {
                if (ticTacToeBoard[1, 1] == "X")
                {
                    Console.WriteLine("Congratulations player One! You have won the game.");
                    PlayAgain();
                }
                else if (ticTacToeBoard[1, 1] == "O")
                {
                    Console.WriteLine("Congratulations player Two! You have won the game.");
                    PlayAgain();
                }
            }//down middle
            else if (ticTacToeBoard[1, 4].Equals("X") && ticTacToeBoard[4, 4].Equals("X") && ticTacToeBoard[7, 4].Equals("X") ||
                ticTacToeBoard[1, 4].Equals("O") && ticTacToeBoard[4, 4].Equals("O") && ticTacToeBoard[7, 4].Equals("O"))
            {
                if (ticTacToeBoard[1, 4] == "X")
                {
                    Console.WriteLine("Congratulations player One! You have won the game.");
                    PlayAgain();
                }
                else if (ticTacToeBoard[1, 4] == "O")
                {
                    Console.WriteLine("Congratulations player Two! You have won the game.");
                    PlayAgain();
                }
            }//down right
            else if (ticTacToeBoard[1, 7].Equals("X") && ticTacToeBoard[4, 7].Equals("X") && ticTacToeBoard[7, 7].Equals("X") ||
                ticTacToeBoard[1, 7].Equals("O") && ticTacToeBoard[4, 7].Equals("O") && ticTacToeBoard[7, 7].Equals("O"))
            {
                if (ticTacToeBoard[1, 7] == "X")
                {
                    Console.WriteLine("Congratulations player One! You have won the game.");
                    PlayAgain();
                }
                else if (ticTacToeBoard[1, 7] == "O")
                {
                    Console.WriteLine("Congratulations player Two! You have won the game.");
                    PlayAgain();
                }
            }//diagnal left to right
            else if (ticTacToeBoard[1, 1].Equals("X") && ticTacToeBoard[4, 4].Equals("X") && ticTacToeBoard[7, 7].Equals("X") ||
                ticTacToeBoard[1, 1].Equals("O") && ticTacToeBoard[4, 4].Equals("O") && ticTacToeBoard[7, 7].Equals("O"))
            {
                if (ticTacToeBoard[1, 1] == "X")
                {
                    Console.WriteLine("Congratulations player One! You have won the game.");
                    PlayAgain();
                }
                else if (ticTacToeBoard[1, 1] == "O")
                {
                    Console.WriteLine("Congratulations player Two! You have won the game.");
                    PlayAgain();
                }
            }//diagnal right to left
            else if (ticTacToeBoard[1, 7].Equals("X") && ticTacToeBoard[4, 4].Equals("X") && ticTacToeBoard[7, 1].Equals("X") ||
                ticTacToeBoard[1, 8].Equals("O") && ticTacToeBoard[4, 5].Equals("O") && ticTacToeBoard[7, 1].Equals("O"))
            {
                if (ticTacToeBoard[1, 7] == "X")
                {
                    Console.WriteLine("Congratulations player One! You have won the game.");
                    PlayAgain();
                }
                else if (ticTacToeBoard[1, 7] == "O")
                {
                    Console.WriteLine("Congratulations player Two! You have won the game.");
                    PlayAgain();
                }
            }
        }
        public static void ChooseSpot(string spot)
        {
            switch (spot)
            {
                case "1":
                    for (int i = 1; i < ticTacToeBoard.GetLength(0); i++)
                    {
                        for (int j = 0; j < ticTacToeBoard.GetLength(1); j++)
                        {
                            if (ticTacToeBoard[i, j] == "1" && isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "X";
                            }
                            else if (ticTacToeBoard[i, j] == "1" && !isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "O";
                            }
                        }
                    }
                    counter++;
                    break;
                case "2":
                    for (int i = 1; i < ticTacToeBoard.GetLength(0); i++)
                    {
                        for (int j = 0; j < ticTacToeBoard.GetLength(1); j++)
                        {
                            if (ticTacToeBoard[i, j] == "2" && isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "X";
                            }
                            else if (ticTacToeBoard[i, j] == "2" && !isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "O";
                            }
                        }
                    }
                    counter++;
                    break;
                case "3":
                    for (int i = 1; i < ticTacToeBoard.GetLength(0); i++)
                    {
                        for (int j = 0; j < ticTacToeBoard.GetLength(1); j++)
                        {
                            if (ticTacToeBoard[i, j] == "3" && isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "X";
                            }
                            else if (ticTacToeBoard[i, j] == "3" && !isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "O";
                            }
                        }
                    }
                    counter++;
                    break;
                case "4":
                    for (int i = 1; i < ticTacToeBoard.GetLength(0); i++)
                    {
                        for (int j = 0; j < ticTacToeBoard.GetLength(1); j++)
                        {
                            if (ticTacToeBoard[i, j] == "4" && isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "X";
                            }
                            else if (ticTacToeBoard[i, j] == "4" && !isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "O";
                            }
                        }
                    }
                    counter++;
                    break;
                case "5":
                    for (int i = 1; i < ticTacToeBoard.GetLength(0); i++)
                    {
                        for (int j = 0; j < ticTacToeBoard.GetLength(1); j++)
                        {
                            if (ticTacToeBoard[i, j] == "5" && isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "X";
                            }
                            else if (ticTacToeBoard[i, j] == "5" && !isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "O";
                            }
                        }
                    }
                    counter++;
                    break;
                case "6":
                    for (int i = 1; i < ticTacToeBoard.GetLength(0); i++)
                    {
                        for (int j = 0; j < ticTacToeBoard.GetLength(1); j++)
                        {
                            if (ticTacToeBoard[i, j] == "6" && isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "X";
                            }
                            else if (ticTacToeBoard[i, j] == "6" && !isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "O";
                            }
                        }
                    }
                    counter++;
                    break;
                case "7":
                    for (int i = 1; i < ticTacToeBoard.GetLength(0); i++)
                    {
                        for (int j = 0; j < ticTacToeBoard.GetLength(1); j++)
                        {
                            if (ticTacToeBoard[i, j] == "7" && isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "X";
                            }
                            else if (ticTacToeBoard[i, j] == "7" && !isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "O";
                            }
                        }
                    }
                    counter++;
                    break;
                case "8":
                    for (int i = 1; i < ticTacToeBoard.GetLength(0); i++)
                    {
                        for (int j = 0; j < ticTacToeBoard.GetLength(1); j++)
                        {
                            if (ticTacToeBoard[i, j] == "8" && isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "X";
                            }
                            else if (ticTacToeBoard[i, j] == "8" && !isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "O";
                            }
                        }
                    }
                    counter++;
                    break;
                case "9":
                    for (int i = 1; i < ticTacToeBoard.GetLength(0); i++)
                    {
                        for (int j = 0; j < ticTacToeBoard.GetLength(1); j++)
                        {
                            if (ticTacToeBoard[i, j] == "9" && isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "X";
                            }
                            else if (ticTacToeBoard[i, j] == "9" && !isPlayerOne)
                            {
                                ticTacToeBoard[i, j] = "O";
                            }
                        }
                    }
                    counter++;
                    break;
            }
        }

        private static bool playerOneWin;
        public readonly static string[,] board = new string[9, 9]
{
        {
            " "," "," |", " "," "," |", " "," "," |\n"
        },
        {
            " ","1"," |", " ","2"," |", " ","3"," |\n"
        },
        {
            "_","_","_|", "_","_","_|","_","_","_|\n"
        },
        {
            " "," "," |", " "," "," |", " "," "," |\n"
        },
        {
            " ","4"," |", " ","5"," |", " ","6"," |\n"
        },
        {
            "_","_","_|", "_","_","_|","_","_","_|\n"
        },
        {
            " "," "," |", " "," "," |", " "," "," |\n"
        },
        {
            " ","7"," |", " ","8"," |", " ","9"," |\n"
        },
        {
            "_","_","_|", "_","_","_|","_","_","_|\n"
        }

};
        private static string[,] ticTacToeBoard = new string[9, 9];
        private static bool isPlayerOne = true;
        private static int counter = 0;
        static void Main()
        {            
            Array.Copy(board, ticTacToeBoard, board.Length);

            while (counter < 9)
            {
                PrintBoard();
                AskPlayerOne();
                PrintBoard();
                CheckIfWon(ticTacToeBoard);
                AskPlayerTwo();
                CheckIfWon(ticTacToeBoard);
            }
            Console.WriteLine("Nobody won this time.");
            PlayAgain();
        }
    }
}

