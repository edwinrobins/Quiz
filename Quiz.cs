using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int highScore = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== C# SMART QUIZ ===");
            Console.WriteLine("1. Start Quiz");
            Console.WriteLine("2. View High Score");
            Console.WriteLine("3. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                int score = StartQuiz();
                Console.WriteLine("Your Score: " + score);

                if (score > highScore)
                {
                    highScore = score;
                    Console.WriteLine("New High Score!");
                }

                Console.WriteLine("Press Enter...");
                Console.ReadLine();
            }
            else if (choice == "2")
            {
                Console.WriteLine("High Score: " + highScore);
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
            }
            else if (choice == "3")
            {
                break;
            }
        }
    }

    static int StartQuiz()
    {
        int score = 0;

        var questions = new Dictionary<string, string>()
        {
            /*You can add, delete or change the code below to cange the quesions (remember if you change the question also remember to change the answer.)*/
            { "What keyword creates a class?", "class" },
            { "Which type stores true/false?", "bool" },
            { "Which loop repeats while true?", "while" }
        };

        foreach (var q in questions)
        {
            int attempts = 0;
            bool correct = false;

            while (attempts < 3 && !correct)
            {
                Console.WriteLine(q.Key);
                Console.Write("Answer: ");
                string answer = Console.ReadLine().ToLower();

                if (answer == q.Value)
                {
                    Console.WriteLine("Correct!");
                    score++;
                    correct = true;
                }
                else
                {
                    attempts++;
                    Console.WriteLine("Wrong");

                    if (attempts == 3)
                    {
                        Console.WriteLine("Answer was: " + q.Value);
                    }
                }
            }

            Console.WriteLine();
        }

        return score;
    }
}
