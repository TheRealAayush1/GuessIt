using System;

namespace GuessTheNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                               Made by TheRealAayush");
            Console.WriteLine(@"
  ▄████  █    ██ ▓█████   ██████   ██████     ██▓▄▄▄█████▓ ▐██▌ 
 ██▒ ▀█▒ ██  ▓██▒▓█   ▀ ▒██    ▒ ▒██    ▒    ▓██▒▓  ██▒ ▓▒ ▐██▌ 
▒██░▄▄▄░▓██  ▒██░▒███   ░ ▓██▄   ░ ▓██▄      ▒██▒▒ ▓██░ ▒░ ▐██▌ 
░▓█  ██▓▓▓█  ░██░▒▓█  ▄   ▒   ██▒  ▒   ██▒   ░██░░ ▓██▓ ░  ▓██▒ 
░▒▓███▀▒▒▒█████▓ ░▒████▒▒██████▒▒▒██████▒▒   ░██░  ▒██▒ ░  ▒▄▄  
 ░▒   ▒ ░▒▓▒ ▒ ▒ ░░ ▒░ ░▒ ▒▓▒ ▒ ░▒ ▒▓▒ ▒ ░   ░▓    ▒ ░░    ░▀▀▒ 
  ░   ░ ░░▒░ ░ ░  ░ ░  ░░ ░▒  ░ ░░ ░▒  ░ ░    ▒ ░    ░     ░  ░ 
░ ░   ░  ░░░ ░ ░    ░   ░  ░  ░  ░  ░  ░      ▒ ░  ░          ░ 
      ░    ░        ░  ░      ░        ░      ░            ░    
                                                                
");
            Random rnd = new Random();
            Console.WriteLine("Welcome to this simple but hard game...");
            difficulty:
            Console.WriteLine("Choose the difficulty : ");
            Console.WriteLine(@"
1 : Easy difficulty (number range is 1 - 10)
2 : Medium difficulty (number range 1 - 30)
3 : Hard difficulty (number range 1 - 50)
4 : Extreme difficulty (number range 1 - 100)
");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            int a, b, c, d;
            int score = 0;
            switch (difficulty)
            {
                case 1:
                    lol1:
                    a = rnd.Next(11);
                    Console.WriteLine("Enter your guess from 0 to 10");
                    firstSecond:
                    int ans = Convert.ToInt32(Console.ReadLine());
                    first:
                    if (ans == a)
                    {
                        Console.WriteLine("Correct answer, enter your next guess : ");
                        score++;
                        goto firstSecond;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect guess, you current score was {score}, Do you want to try again or change the difficulty?");
                        Console.WriteLine(@"
1 : Try again
2 : Change difficulty
3 : Quit game
");
                        int choice1 = Convert.ToInt32(Console.ReadLine());
                        if (choice1 == 1)
                        {
                            goto lol1;
                        }
                        else if (choice1 == 2)
                        {
                            goto difficulty;
                        }
                        else
                        {
                            goto end1;
                        }
                    }
                    goto first;
                    end1:
                    break;
                case 2:
                lol2:
                    b = rnd.Next(31);
                    Console.WriteLine("Enter your guess from 0 to 30");
                secondSecond:
                    int ans1 = Convert.ToInt32(Console.ReadLine());
                second:
                    if (ans1 == b)
                    {
                        Console.WriteLine("Correct answer, enter your next guess : ");
                        score++;
                        goto secondSecond;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect guess, you current score was {score}, Do you want to try again or change the difficulty?");
                        Console.WriteLine(@"
1 : Try again
2 : Change difficulty
3 : Quit game
");
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        if (choice2 == 1)
                        {
                            goto lol2;
                        }
                        else if (choice2 == 2)
                        {
                            goto difficulty;
                        }
                        else
                        {
                            goto end2;
                        }
                    }
                    goto second;
                end2:
                    break;
                case 3:
                lol3:
                    c = rnd.Next(51);
                    Console.WriteLine("Enter your guess from 0 to 50");
                thirdSecond:
                    int ans2 = Convert.ToInt32(Console.ReadLine());
                third:
                    if (ans2 == c)
                    {
                        Console.WriteLine("Correct answer, enter your next guess : ");
                        score++;
                        goto thirdSecond;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect guess, you current score was {score}, Do you want to try again or change the difficulty?");
                        Console.WriteLine(@"
1 : Try again
2 : Change difficulty
3 : Quit game
");
                        int choice3 = Convert.ToInt32(Console.ReadLine());
                        if (choice3 == 1)
                        {
                            goto lol3;
                        }
                        else if (choice3 == 2)
                        {
                            goto difficulty;
                        }
                        else
                        {
                            goto end3;
                        }
                    }
                    goto third;
                end3:
                    break;
                case 4:
                lol4:
                    d = rnd.Next(101);
                    Console.WriteLine("Enter your guess from 0 to 100");
                fourthSecond:
                    int ans3 = Convert.ToInt32(Console.ReadLine());
                fourth:
                    if (ans3 == d)
                    {
                        Console.WriteLine("Correct answer, enter your next guess : ");
                        score++;
                        goto fourthSecond;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect guess, you current score was {score}, Do you want to try again or change the difficulty?");
                        Console.WriteLine(@"
1 : Try again
2 : Change difficulty
3 : Quit game
");
                        int choice4 = Convert.ToInt32(Console.ReadLine());
                        if (choice4 == 1)
                        {
                            goto lol4;
                        }
                        else if (choice4 == 2)
                        {
                            goto difficulty;
                        }
                        else
                        {
                            goto end4;
                        }
                    }
                    goto fourth;
                end4:
                    break;
            }
        }
    }
}
