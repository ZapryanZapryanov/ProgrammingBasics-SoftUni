using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradus = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string outfit = "";
            string outfit2 = "";

            if (gradus >= 10 && gradus <= 18)
            {
                if (time == "Morning")
                {
                    outfit = "Sweatshirt";
                    outfit2 = "Sneakers";
                }
                else if (time == "Afternoon")
                {
                    outfit = "Shirt";
                    outfit2 = "Moccasins";
                }
                else
                {
                    outfit = "Shirt";
                    outfit2 = "Moccasins";
                }
            }
            else if (gradus <= 24)
            {
                if (time == "Morning")
                {
                    outfit = "Shirt";
                    outfit2 = "Moccasins";
                }

                else if (time == "Afternoon")
                {
                    outfit = "T-Shirt";
                    outfit2 = "Sandals";
                }
                else
                {
                    outfit = "Shirt";
                    outfit2 = "Moccasins";
                }
            }
            else
            {
                if (time == "Morning")
                {
                    outfit = "T-Shirt";
                    outfit2 = "Sandals";
                }
                else if (time == "Afternoon")
                {
                    outfit = "Swim Suit";
                    outfit2 = "Barefoot";
                }
                else
                {
                    outfit = "Shirt";
                    outfit2 = "Moccasins";
                }

            }
            Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {outfit2}.");

        }
    }
}
