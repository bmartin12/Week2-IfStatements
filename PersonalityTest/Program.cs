using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("whats yer fav color");
            string UserColor = Console.ReadLine().ToLower();

            if(UserColor == "red")
            {
                Console.WriteLine("yer a blood haha lol");
            }
            else if(UserColor == "blue")
            {
                Console.WriteLine("yer a crip haha lol");
            }
            else if(UserColor == "green")
            {
                Console.WriteLine("yer either a vegan or a stoner :P");
            }
            else if(UserColor == "purple")
            {
                Console.WriteLine("yer probs gay tbh");
            }
            else if(UserColor == "pink")
            {
                Console.WriteLine("yer defs gay :PPPPP");
            }
            else
            {
                Console.WriteLine("yer a wizard harry");
            }


        }
    }
}
