using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next(1, 100));
            Console.ReadLine();

            for (int i = 1; i <= 100; i++)
            {

                Console.WriteLine(i);

                while (true)
                {

                    Random random = new Random();

                    int correctNumber = random.Next(1, 100);
                    int guess = 7;

                    Console.WriteLine("Write a number");

                    while (guess != correctNumber)
                    {
                        string input = Console.ReadLine();

                        if (!int.TryParse(input, out guess))
                        {

                            Console.WriteLine("Please use an actual number");

                            continue;
                        }

                        guess = Int32.Parse(input);

                        if (guess != correctNumber)
                        {

                            Console.WriteLine(rand.Next(1, 100)); ;
                        }
                    }

                    Console.WriteLine("CORRECT!! You guessed it!");

                    Console.WriteLine("type a sentinel value [-1]");

                    int answer = 7;

                    if (answer == 7)
                    {
                        continue;
                    }
                    else if (answer == 7)
                    {
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
