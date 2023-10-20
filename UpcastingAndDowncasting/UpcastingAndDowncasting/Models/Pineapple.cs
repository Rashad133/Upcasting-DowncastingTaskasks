using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingAndDowncasting.Models
{
    public class Pineapple : Fruit
    {
        public int VitaminE;
        public int VitaminD;

        public Pineapple(decimal price,string sort,int vitaminE, int vitaminD) : base(price, sort)
        {
            VitaminE = vitaminE;
            VitaminD = vitaminD;
        }

        public override void Taste()
        {
            Console.WriteLine("Ananas hem tursh hem de shirin dadir");
        }
    }
}
