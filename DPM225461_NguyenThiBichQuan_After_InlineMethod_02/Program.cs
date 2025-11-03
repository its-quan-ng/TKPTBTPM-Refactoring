using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_After_InlineMethod_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaDelivery delivery = new PizzaDelivery();
            delivery.numberOfLateDeliveries = 6;
            Console.WriteLine($"Rating: {delivery.GetRating()}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public class PizzaDelivery
        {
            public int numberOfLateDeliveries;
            public int GetRating()
            {
                return numberOfLateDeliveries > 5 ? 2 : 1;
            }
        }
    }
}
