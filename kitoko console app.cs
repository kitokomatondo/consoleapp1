using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, I'm a console App made by your colleague Kitoko. \n \n What's your name?");
            string response = Console.ReadLine();
            Console.WriteLine($"Hello, {response}! How long have you been working at Kindee?");
            string response2 = Console.ReadLine();
            Console.WriteLine($"{response2}? Cool! \n \n  Well i don't wanna bother you {response} \n I know you got alot of work to do. \n \n Have a nice day {response}!");
        }
    }
}
