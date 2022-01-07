using System;
namespace userInput
{
    class userInput
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Your age is: " + age);

            Console.WriteLine("Enter your name ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName +" \nYour age is : "+age);



        }
    }
}