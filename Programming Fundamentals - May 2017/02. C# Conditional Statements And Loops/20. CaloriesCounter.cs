using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalCalories = 0;
            for (int i = 0; i < n; i++)
            {
                string ingredient = Console.ReadLine();
                if (String.Compare(ingredient.ToLower(), "cheese", true) == 0)
                    totalCalories += 500;
                else if (String.Compare(ingredient.ToLower(), "tomato sauce", true) == 0)
                    totalCalories += 150;
                else if (String.Compare(ingredient.ToLower(), "salami", true) == 0)
                    totalCalories += 600;
                else if (String.Compare(ingredient.ToLower(), "pepper", true) == 0)
                    totalCalories += 50;
            }
            Console.WriteLine("Total calories: " + totalCalories);
        }
    }
}
