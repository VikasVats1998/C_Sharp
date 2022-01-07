using System;
namespace mathFunctions
{
    class mathFunctions
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Enter two no.");
           int a =Convert.ToInt32( Console.ReadLine());
           int b = Convert.ToInt32(Console.ReadLine());

           int max = Math.Max(a,b);

          int min =  Math.Min(a,b);

          double sqrt_a = Math.Sqrt(a);

           Console.WriteLine("Maximum no. : "+max + "\nMinum no : "+min);
           Console.WriteLine("Square root of A : "+sqrt_a);
           





        }
    }
}