using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingAndDowncasting.Models
{
    public class Orange : Fruit
    {
       
        public int VitaminC;
       

        public Orange(decimal price, string sort, int vitaminC) : base(price, sort)
        {
            VitaminC= vitaminC;
        }

        public override void Taste()
        {
            Console.WriteLine("Portagalin tursh dadi var");
        }
    }
}
