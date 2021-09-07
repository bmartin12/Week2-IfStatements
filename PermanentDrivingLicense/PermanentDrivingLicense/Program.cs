using System;

namespace PermanentDrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on pisavalt vana
            //et juhiluba saada

            Console.WriteLine("when was u born fam?");

            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            if (Age >= 18)
            {
                Console.WriteLine("yer old enough to get you a fancy drivin license :D");
            }
            else
            {
                Console.WriteLine("yer wayyy too young fam better luck next time :(");
            }

        }
    }
}
