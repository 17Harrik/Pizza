using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toppings = new List<string> {
                "Pepperoni","Margherita","Ham and pineapple"
        };

            string selection = ChooseFrom(toppings);
            Console.WriteLine($"You have chosen {selection}");
        }

        private static string ChooseFrom(List<string> toppings)
        {
         

            // repeat until  user input is valid
            bool valid = false;
            int chosenPosition = -1;

            while (valid == false)
            {
                for (int i = 0; i < toppings.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {toppings[i]}");
                }

                Console.Write($"Choose a number (1-{toppings.Count}) ");
                string response = Console.ReadLine();

                if (int.TryParse(response, out chosenPosition) &&
                    chosenPosition > 0 &&
                    chosenPosition <= toppings.Count)
                {
                    valid = true;
                }

            }

            return toppings[chosenPosition - 1];
        }
    }
}