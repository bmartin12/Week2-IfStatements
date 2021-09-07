using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust
            //Kui kasutaja on vanem, kui 18, siis koonsoolis kuvatakse "oledpiisavalt vana"
            //Kui kasutaja on noorem, kui 18, siis konsolis kuvatakse "oled liiga noor"
            //Kui kasutaja on 18, siis konsoolis kuvatakse "oledki 18"

            Console.WriteLine("how old r u?!");

            int Age = Int32.Parse(Console.ReadLine());

            if (Age > 18)
            {
                Console.WriteLine("yer old enuf i tink g, go on.");
            }
            else if (Age < 18)
            {
                Console.WriteLine("yer weyyy too young my g, piss off!");
            }
            else
            {
                Console.WriteLine("yer 18!?");
            }

            Console.WriteLine("alr fam cya :)");


        }
    }
}
