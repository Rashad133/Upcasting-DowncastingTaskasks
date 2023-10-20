using System.Reflection;
using UpcastingAndDowncasting.Models;

namespace UpcastingAndDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple { Price = 3, Sort = "Delfi", VitaminA = 20, VitaminB = 25 };
            Orange orange = new Orange{Price = 2, Sort = "Lima", VitaminC = 30};
            Pineapple pineapple = new Pineapple{ Price = 1, Sort ="Panare",VitaminD=25,VitaminE=35};


            Fruit[] basket = { apple, orange, pineapple };


            Console.WriteLine("------------");

            foreach(Fruit fruit in basket)
            {
                Type type = fruit.GetType();
                FieldInfo[] fields = type.GetFields(System.Reflection.BindingFlags.Public | BIndingFlags.Instance);
            }

            Console.WriteLine();
          
        }
    }
}