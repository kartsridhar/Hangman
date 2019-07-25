using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Program
    {
        // 0. [EXTRA]
        static string GenerateRandomCompliment()
        {
            string[] compliment = new string[5];
            compliment[0] = "Going good!";
            compliment[1] = "On the right track!";
            compliment[2] = "Keep going!";
            compliment[3] = "You are almost there";
            compliment[4] = "Awesome!";
            Random randomWord = new Random();
            int randomIndex = randomWord.Next(0, 4);
            string word = compliment[randomIndex];
            return word;
        }

        // 1. Function to simply choose a random word of this list
        static string GenerateRandomWord()
        {
            string[] words = new string[5];
            words[0] = "hello";
            words[1] = "world";
            words[2] = "check";
            words[3] = "program";
            words[4] = "hangman";
            Random randomWord = new Random();
            int randomIndex = randomWord.Next(0, 4);
            string word = words[randomIndex];
            return word;
        }

        // 2. Function to check and replace user's guess
        static string CheckLetterGuess(string wordToGuess, List<string> guessed)
        {
            string correctGuess = "";
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                string check = Convert.ToString(wordToGuess[i]);
                if (guessed.Contains(check))
                {
                    correctGuess += check;
                }
                else
                {
                    correctGuess += "_ ";
                }
            }
            return correctGuess;
        }

        // 3. Function to check if user enters the right word
        static bool CheckWordGuess(string wordToGuess, List<string> guessed)
        {
            bool check = false;
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                string guess = Convert.ToString(wordToGuess);
                if (guessed.Contains(guess))
                {
                    check = true;
                }
                else
                {
                    return false;
                }
            }
            return check;
        }

        // 4. Function to get the available alphabets after an attempt
        static void GetAvailableAlphabet(string alphabets)
        {
            List<string> alphabet = new List<string>();
            for (int i = 1; i <= 26; i++)
            {
                char letter = Convert.ToChar(i + 96);
                alphabet.Add(Convert.ToString(letter));
            }
            int num = 49;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Remaining Alphabets: ");

            for (int i = 0; i < num; i++)
            {
                if (alphabets.Contains(alphabets))
                {
                    alphabet.Remove(alphabets);
                    num -= 1;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" " + alphabet[i] + ",");
            }
        }

        // 5. Function to draw the hangman based on lives
        static void DrawMan(int lives)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            if (lives == 8)
            {
                Console.WriteLine("           H A N G M A N                ");
                Console.WriteLine("                             ,____      ");
                Console.WriteLine("                             |    |     ");
                Console.WriteLine("                             O    |     ");
                Console.WriteLine("                            /|\\   |     ");
                Console.WriteLine("                             |    |     ");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("                            / \\   |     ");
                Console.WriteLine("                            _____/|     ");
                Console.WriteLine("                                        ");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (lives == 7)
            {
                Console.WriteLine("           HANGMAN                      ");
                Console.WriteLine("                             ,____      ");
                Console.WriteLine("                             |    |     ");
                Console.WriteLine("                                  |     ");
                Console.WriteLine("                                  |     ");
                Console.WriteLine("                                  |     ");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("                                  |     ");
                Console.WriteLine("                            _____/|     ");
                Console.WriteLine("                                        ");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (lives == 6)
            {
                Console.WriteLine("           H                            ");
                Console.WriteLine("                             ,____      ");
                Console.WriteLine("                             |    |     ");
                Console.WriteLine("                             O    |     ");
                Console.WriteLine("                                  |     ");
                Console.WriteLine("                                  |     ");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("                                  |     ");
                Console.WriteLine("                            _____/|     ");
                Console.WriteLine("                                        ");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (lives == 5)
            {
                Console.WriteLine("           H A                          ");
                Console.WriteLine("                             ,____      ");
                Console.WriteLine("                             |    |     ");
                Console.WriteLine("                             O    |     ");
                Console.WriteLine("                             |    |     ");
                Console.WriteLine("                                  |     ");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("                                  |     ");
                Console.WriteLine("                            _____/|     ");
                Console.WriteLine("                                        ");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (lives == 4)
            {
                Console.WriteLine("           H A N                        ");
                Console.WriteLine("                             ,____      ");
                Console.WriteLine("                             |    |     ");
                Console.WriteLine("                             O    |     ");
                Console.WriteLine("                            /|    |     ");
                Console.WriteLine("                                  |     ");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("                                  |     ");
                Console.WriteLine("                            _____/|     ");
                Console.WriteLine("                                        ");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (lives == 3)
            {
                Console.WriteLine("           H A N G                      ");
                Console.WriteLine("                             ,____      ");
                Console.WriteLine("                             |    |     ");
                Console.WriteLine("                             O    |     ");
                Console.WriteLine("                            /|\\   |     ");
                Console.WriteLine("                                  |     ");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("                                  |     ");
                Console.WriteLine("                            _____/|     ");
                Console.WriteLine("                                        ");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (lives == 2)
            {
                Console.WriteLine("           H A N G M                    ");
                Console.WriteLine("                             ,____      ");
                Console.WriteLine("                             |    |     ");
                Console.WriteLine("                             O    |     ");
                Console.WriteLine("                            /|\\   |     ");
                Console.WriteLine("                             |    |     ");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("                                  |     ");
                Console.WriteLine("                            _____/|     ");
                Console.WriteLine("                                        ");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (lives == 1)
            {
                Console.WriteLine("           H A N G M A                  ");
                Console.WriteLine("                             ,____      ");
                Console.WriteLine("                             |    |     ");
                Console.WriteLine("                             O    |     ");
                Console.WriteLine("                            /|\\   |     ");
                Console.WriteLine("                             |    |     ");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("                            /     |     ");
                Console.WriteLine("                            _____/|     ");
                Console.WriteLine("                                        ");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static void Main(string[] args)
        {
            Console.Title = ("Simple Hangman");

            string wordToGuess = GenerateRandomWord();
            List<string> guessed = new List<string>();

            int lives = 7;
            DrawMan(8);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Start guessing for this {0} letter word", wordToGuess.Length);

            CheckLetterGuess(wordToGuess, guessed);

            while (lives > 0)
            {
                string InputGuess = Console.ReadLine();

                if (guessed.Contains(InputGuess))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Oops, you have already entered this letter: {0}", InputGuess);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Try a different letter");
                    GetAvailableAlphabet(InputGuess);
                    Console.WriteLine("");
                    continue;
                }

                guessed.Add(InputGuess);

                if (CheckWordGuess(wordToGuess, guessed))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Actual word: {0}", wordToGuess);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("BINGO! You guessed the word!!");
                    break;
                }
                else if (wordToGuess.Contains(InputGuess))
                {
                    Console.WriteLine(GenerateRandomCompliment());
                    string letters = CheckLetterGuess(wordToGuess, guessed);
                    Console.Write(letters);
                    Console.WriteLine("");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Oops, wrong letter!");
                    lives -= 1;
                    DrawMan(lives);
                    Console.WriteLine("Remaining Lives: {0}", lives);
                }
                if (lives == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Oh no! G A M E  O V E R");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The actual word was: {0}", wordToGuess);
                    break;
                }
            }
            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
        }


    }
}

