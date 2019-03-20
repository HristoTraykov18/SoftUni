using System;
using System.Linq;

namespace PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredientsArr = Console.ReadLine().Split(' ').ToArray();
            int len = int.Parse(Console.ReadLine());
            string ingredientsUsed = "";
            int ingredientsCount = 0;
            for (int i = 0; i < ingredientsArr.Length; i++)
            {
                if (ingredientsCount > 9)
                    break;
                if (ingredientsArr[i].Length == len)
                {
                    Console.WriteLine($"Adding {ingredientsArr[i]}.");
                    ingredientsUsed += ingredientsArr[i] + ", ";
                    ingredientsCount++;
                }
            }
            ingredientsUsed = ingredientsUsed.Remove(ingredientsUsed.Length - 2);
            Console.WriteLine($"Made pizza with total of {ingredientsCount} ingredients.");
            Console.WriteLine($"The ingredients are: {ingredientsUsed}.");
        }
    }
}
