using System;
using System.Collections.Generic;

namespace multifabriken_Muzze1994
{
    class Program
    {
        static void Main(string[] args)
        {

            //Lists for all created classes
            List<Tofu> tofu = new List<Tofu>();
            List<Car> car = new List<Car>();
            List<Candy> candy = new List<Candy>();
            List<Strings> strings = new List<Strings>();

            //Used in the while-loop to keep the program running 
            bool isRunning = true;

            //Makes the program running until you give the wrong input-type or press the number 6
            while (isRunning)
            {

                //Menu for the program 
                Console.WriteLine("\n\tVälkommen till multifabriken!");
                Console.WriteLine("\t[1] Beställ tofu");
                Console.WriteLine("\t[2] Beställ godis");
                Console.WriteLine("\t[3] Beställ bilar");
                Console.WriteLine("\t[4] Beställ snören");
                Console.WriteLine("\t[5] Lista alla dina beställda produlkter");
                Console.WriteLine("\t[6] Avsluta programmet");
                Console.WriteLine("\tVälj: ");
                int menu = Convert.ToInt32(Console.ReadLine());

                //When you press a number between 1-6 a different case happens depending on what number you press
                switch (menu)
                {
                    //Case 1-4 you add a new object into a list depending on what number you chose
                    //1 for tofu, 2 for candy etc
                    case 1:

                        string spice = "";
                        int volume = 0;

                        Console.WriteLine("Du valde att beställa tofu!");
                        Console.WriteLine("Välj volymen: ");
                        volume = (Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Välj kryddningen: ");
                        spice = Console.ReadLine();

                        //A new object gets added with the information the user provided, same for all cases 1-4
                        tofu.Add(new Tofu { Spice = spice, Volume = volume });

                        break;

                    case 2:

                        string taste = "";
                        int quantity = 0;

                        Console.WriteLine("Du valde att beställa godis!");
                        Console.WriteLine("Välj antal: ");
                        quantity = (Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Välj smak: ");
                        taste = Console.ReadLine();

                        candy.Add(new Candy { Taste = taste, Quantity = quantity });

                        break;

                    case 3:

                        string regnr = "";
                        string carColor = "";
                        string brand = "";

                        Console.WriteLine("Du valde att beställa en bil!");
                        Console.WriteLine("Välj regnr: ");
                        regnr = Console.ReadLine();
                        Console.WriteLine("Välj färg: ");
                        carColor = Console.ReadLine();
                        Console.WriteLine("Välj bilmärke");
                        brand = Console.ReadLine();

                        car.Add(new Car { Regnr = regnr, Color = carColor, Brand = brand });

                        break;
                    case 4:

                        string stringColor = "";
                        int length = 0;

                        Console.WriteLine("Du valde att beställa snören!");
                        Console.WriteLine("Välj längd: ");
                        length = (Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Välj färg: ");
                        stringColor = Console.ReadLine();

                        strings.Add(new Strings { StringColor = stringColor, Length = length });

                        break;
                    case 5:
                        
                        //If there is nothing in the list for each class there is no output in the console
                        //If the list is not empty you write out each object in the list in a consol.writeline
                        if (tofu.Count != 0)
                        {
                            Console.WriteLine("Tofu ");
                            foreach (Tofu tofus in tofu)
                            {
                                Console.WriteLine($"Volym: {tofus.Volume}g Krydda: {tofus.Spice}");
                            }
                        }

                        if (car.Count != 0)
                        {
                            Console.WriteLine("Bilar ");
                            foreach (Car cars in car)
                            {
                                Console.WriteLine($"Regnr: {cars.Regnr} Färg: {cars.Color} Märke: {cars.Brand}");
                            }

                        }

                        if (candy.Count != 0)
                        {
                            Console.WriteLine("Godis ");
                            foreach (Candy candys in candy)
                            {
                                Console.WriteLine($"Kvantitet: {candys.Quantity}st Smak: {candys.Taste}");
                            }

                        }

                        if (strings.Count != 0)
                        {
                            Console.WriteLine("Snören ");
                            foreach (Strings String in strings)
                            {
                                Console.WriteLine($"Färg: {String.StringColor} Längd: {String.Length}m");
                            }

                        }

                        break;

                    //If you press the number 6 the program will exit
                    case 6:

                        Console.WriteLine("Nu avslutas programmet!");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
