using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User");

            const int MaxLength = 140;
            var message = " ";

            do
            {
                Console.WriteLine("Please type out the message you wish to write for the service provider. The message must not exceed 140 characters: ");
                message = Console.ReadLine();

                if (message.Length <= MaxLength)
                {
                    Console.WriteLine("Messsage is sent");
                    break;
                }
                else
                {
                    Console.WriteLine("You have exceeded the given amount of characters please try again! ");
                }
            } while (message.Length > MaxLength);
        }
    }
}
