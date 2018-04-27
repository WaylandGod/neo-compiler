using System;

namespace fixed_point_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = sizeof(decimal);
            var i = sizeof(int);
            var l = sizeof(long);
            var f = sizeof(float);
            var dd = sizeof(double);

            var t1 = ((double) (1 / 103.0)) * 103;
            var t2 = ((float) (1 / 103.0F)) * 103;
            Console.WriteLine("((double)(1/103.0))*103 < 1 is {0}.", t1);
            Console.WriteLine("((float)(1/103.0F))*103 > 1 is {0}.", t2);


            float price = 4.99F;
            int quantity = 17;
            float total = price * quantity;
            Console.WriteLine("The total price is ${0}.", total);


            long fullPrice = 100;
            double discount = 0.1;
            var pp = (fullPrice * (1 - discount));
            long finalPrice = (long) (fullPrice * (1 - discount));
            Console.WriteLine("The discounted price is ${0}.", finalPrice);
        }
    }
}