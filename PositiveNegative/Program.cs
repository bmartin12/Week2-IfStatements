using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisetada numbrit
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab "number on positiivne"
            //kui number on negattive, konsool kuvab "number on negatiivne"
            //kui sisestatud number on 0, siis konsool kuvab "null";
            //NB!Int32.Parse asemel kasutama Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta number pls"); 
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("number on positiivne lol");
            }
            else if (number < 0)
            {
                Console.WriteLine("number on negatiivne lol");
            }
            else
            {
                Console.WriteLine("null");
            }
        }
    }
}
