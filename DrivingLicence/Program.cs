using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"oled liiga noor, et juhilube saada";
            //kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhilube saada";
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd saad sa juhilube taotleda!"

            Console.WriteLine("Palun sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            Console.WriteLine($"Oled {userAge} aastat vana.");

            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");
            }

            else if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");
            }

            else
            {
                Console.WriteLine("Palju õnne! Nüüd saad sa juhilaube taotleda!");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
