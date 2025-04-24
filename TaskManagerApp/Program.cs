using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp
{
    internal class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            bool continueApp = true;
            while (continueApp)
            {
                DisplayMenu();
                int choice = GetValidChoice();

                switch (choice)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        RemoveTask();
                        break;
                    case 3:
                        DisplayTasks();
                        break;
                    case 4:
                        continueApp = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("To-Do List App");
            Console.WriteLine("----------------");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Remove Task");
            Console.WriteLine("3. Display Tasks");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
        }

        static int GetValidChoice()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 4)
                    return choice;
                else
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            }
        }

        static void AddTask()
        {
            Console.Write("Enter task: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added successfully!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void RemoveTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available to remove.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            DisplayTasks();
            bool ans = true;
            while (ans)
            {
                Console.Write("Enter task number to remove: ");
                if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
                {
                    tasks.RemoveAt(taskNumber - 1);
                    Console.WriteLine("Task removed successfully!");
                    ans = false;
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void DisplayTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Your Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

}

/*static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {
                getChoice();
                playAgain = askToPlay();
            }
            
        }
        static bool askToPlay()
        {
            while (true)
            {
                Console.WriteLine("Do you want to use again");
                string answer = Console.ReadLine().Trim().ToLower();
                if (answer == "yes")
                    return true;
                else if (answer == "no")
                    return false;
                else
                    Console.WriteLine("Please say yes or no only");
            }
            
        }
        static int getValidNum()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int n))
                    return n;
                else
                    Console.WriteLine("Enter proper intrger!");
            }
            
        }
        static int getValidChoice()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int n) && n>=1 && n<=4)
                    return n;
                else
                    Console.WriteLine("Enter proper intrger or make proper choice!");
            }

        }
        static void getChoice()
        {
            Console.Write("Enter first number:");
            int n1 = getValidNum();
            Console.Write("\nEnter second number:");
            int n2 = getValidNum();
            makeChoice();
            int choice = getValidChoice();
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Addition: {n1} + {n2} = {n1 + n2}");
                    break;
                case 2:
                    Console.WriteLine($"Sutraction: {n1} - {n2} = {n1 - n2}");
                    break;
                case 3:
                    Console.WriteLine($"Multiplication: {n1} * {n2} = {n1 * n2}");
                    break;
                case 4:
                    if(n2 == 0)                 
                        Console.WriteLine("Cannot devide by zero!");
                    else
                        Console.WriteLine($"Division: {n1} / {n2} = {(double)(n1 / n2)}");
                    break;
                default:
                    break;
            }
            
        }
        static void makeChoice()
        {
            Console.WriteLine("Choose one option from below:" +
                "\n1.Addition \n2.Subtraction \n3.Multiplication \n4.Division");
            Console.Write("\nEnter your choice: ");
        }*/
/*bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine("Rock, Paper, Scissors Game");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");

                int userChoice = GetValidChoice("Enter your choice (1, 2, or 3): ");
                int computerChoice = GetComputerChoice();

                Console.WriteLine($"You chose: {GetChoiceName(userChoice)}");
                Console.WriteLine($"Computer chose: {GetChoiceName(computerChoice)}");

                DetermineWinner(userChoice, computerChoice);

                playAgain = AskToPlayAgain();
            }
        }

        static int GetValidChoice(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 3)
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                }
            }
        }

        static int GetComputerChoice()
        {
            Random random = new Random();
            return random.Next(1, 4); // Generates a random number between 1 and 3
        }

        static string GetChoiceName(int choice)
        {
            switch (choice)
            {
                case 1:
                    return "Rock";
                case 2:
                    return "Paper";
                case 3:
                    return "Scissors";
                default:
                    throw new ArgumentException("Invalid choice");
            }
        }

        static void DetermineWinner(int userChoice, int computerChoice)
        {
            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userChoice == 1 && computerChoice == 3) ||
                     (userChoice == 2 && computerChoice == 1) ||
                     (userChoice == 3 && computerChoice == 2))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }
        }

        static bool AskToPlayAgain()
        {
            while (true)
            {
                Console.Write("Do you want to play again? (yes/no): ");
                string input = Console.ReadLine().ToLower();
                if (input == "yes")
                {
                    return true;
                }
                else if (input == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter yes or no.");
                }
            }*/
//i want to practice c# language. i am using c# console app(.net framework) in visual studio. give me programm definations one by one(only defination, not solution until i ask for it.) i will perform that task and shall provide you my solution. evaluate it and give correction if any and move on to next one. start with easy and turn by turn improve difficulty slightly.

/*int n;
            while (true) {
                Console.Write("Enter array length: ");
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
                Console.Write("Please enter valid integer!");
            }
            int[] a = new int[n];
            for (int i = 0; i < n; i++) 
            {
                Console.Write($"Enter {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nYour entered array is mentined below:");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

            int s;
            while (true)
            {
                Console.Write("\n\nPlease select one option from below:" +
                "\n1.Find the maximum number in the array. " +
                "\n2.Find the minimum number in the array." +
                "\n3.Calculate the sum of all numbers in the array." +
                "\n4.Calculate the average of all numbers in the array" + 
                "\nEnter selection: ");
                if (int.TryParse(Console.ReadLine(), out s))
                    break;
                Console.Write("\nPlease enter valid integer!");
            }
            switch (s)
            {
                case 1:
                    int index = a[0];
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (index < a[i])
                        {
                            index = a[i];

                        }
                    }
                    Console.WriteLine("\nMax is: " + index);
                    break;
                case 2:
                    index = a[0];
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (index > a[i])
                        {
                            index = a[i];

                        }
                    }
                    Console.WriteLine("\nMin is: " + index);
                    break;
                case 3:
                    int sum = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        sum += a[i];
                    }
                    Console.WriteLine("\nSum is: " + sum);
                    break;
                case 4:
                    int sum2 = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        sum2 += a[i];
                    }
                    Console.WriteLine("\nAvg is: " + sum2/a.Length);
                    break;
                default:
                    break;
            }

            

            Console.ReadLine();*/
/* Console.Write("Enter numbers separated by spaces:");
                string[] inputs = Console.ReadLine().Split();

                int sum = 0;
                foreach (string input in inputs)
                {
                    if (int.TryParse(input, out int number))
                    {
                        sum += number;
                    }
                    else
                    {
                        Console.WriteLine($"Ignoring non-numeric input: {input}");
                    }
                }
                Console.WriteLine($"Sum of numbers: {sum}");*/
/*static void Main(string[] args)
{
    Random random = new Random();
    int targetNumber = random.Next(1, 101); // Adjusted range
    int guess;

    while (true)
    {
        guess = GetValidGuess("Guess a number: ");
        
        if (guess < targetNumber)
        {
            Console.WriteLine("Try a higher number!");
        }
        else if (guess > targetNumber)
        {
            Console.WriteLine("Try a lower number!");
        }
        else
        {
            Console.WriteLine("You guessed it!");
            break;
        }
    }
    Console.ReadLine();
}

static int GetValidGuess(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out int guess))
        {
            return guess;
        }
        else
        {
            Console.WriteLine("Please enter a number properly!");
        }
    }
}
*/