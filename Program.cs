using System;
using System.Collections.Generic;

namespace multifabriken_Muzze1994
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Tofu> tofu = new List<Tofu>();
            List<Car> car = new List<Car>();
            List<Candy> candy = new List<Candy>();
            List<Strings> strings = new List<Strings>();

            bool isRunning = true;


            while (isRunning)
            {
                Console.WriteLine("\n\tVälkommen till multifabriken!");
                Console.WriteLine("\t[1] Beställ tofu");
                Console.WriteLine("\t[2] Beställ godis");
                Console.WriteLine("\t[3] Beställ bilar");
                Console.WriteLine("\t[4] Beställ snören");
                Console.WriteLine("\t[5] Lista alla dina beställda produlkter");
                Console.WriteLine("\t[6] Avsluta programmet");
                Console.WriteLine("\tVälj: ");
                int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:

                        string spice = "";
                        int volume = 0;

                        Console.WriteLine("Du valde att beställa tofu!");
                        Console.WriteLine("Välj volymen: ");
                        volume = (Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Välj kryddningen: ");
                        spice = (Console.ReadLine());

                        tofu.Add(new Tofu { Spice = spice, Volume = volume });


                        break;

                    case 2:

                        string taste = "";
                        int quantity = 0;

                        Console.WriteLine("Du valde att beställa tofu!");
                        Console.WriteLine("Välj antal: ");
                        quantity = (Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Välj smak: ");
                        taste = (Console.ReadLine());

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

                        Console.WriteLine("Du valde att beställa tofu!");
                        Console.WriteLine("Välj längd: ");
                        length = (Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Välj färg: ");
                        stringColor = (Console.ReadLine());

                        strings.Add(new Strings { StringColor = stringColor, Length = length });
                        break;
                    case 5:


                        if (tofu.Count != 0)
                        {
                            Console.WriteLine("Tofu ");
                            foreach (Tofu tofus in tofu)
                            {

                                Console.WriteLine($"Volym: {tofus.Volume} Krydda: {tofus.Spice}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du har inte beställt tofu!");
                        }
                        if (car.Count != 0)
                        {
                            Console.WriteLine("Bilar ");
                            foreach (Car cars in car)
                            {
                                Console.WriteLine($"Regnr: {cars.Regnr} Färg: {cars.Color} Märke: {cars.Brand}");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Du har inte beställt någon bil!");
                        }
                        if (candy.Count != 0)
                        {
                            Console.WriteLine("Godis ");
                            foreach (Candy candys in candy)
                            {
                                Console.WriteLine($"Kvantitet: {candys.Quantity} Smak: {candys.Taste}");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Du har inte beställt något godis!");
                        }
                        if (strings.Count != 0)
                        {
                            Console.WriteLine("Strängar ");
                            foreach (Strings String in strings)
                            {
                                Console.WriteLine($"Färg: {String.StringColor} Längd: {String.Length}");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Du har inte beställt några strängar!");
                        }

                        break;

                    case 6:

                        Console.WriteLine("Nu avslutas programmet!");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
