using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingAndDowncasting.Models
{
    public class Apple:Fruit
    {
        public int VitaminA;
        public int VitaminB;

        public Apple(decimal price, string sort, int vitaminA, int vitaminB): base(price, sort)
        {
            VitaminA = vitaminA;
            VitaminB = vitaminB;
        }

        public override void Taste()
        {
            Console.WriteLine("Alma hem tursh hem de shirin dadir");
        }
    }
}
