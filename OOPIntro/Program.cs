
using System;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Customer();
            while (true)
            {
                Console.WriteLine("Do you want to make a purchase?");
                if (Console.ReadLine().ToLower() == "yes") 
                {

                    Console.WriteLine("We have three types of jackets!");

                    Console.WriteLine("Press");
                    Console.WriteLine("1-Winter Jacket");
                    Console.WriteLine("2-Summer Jacket");
                    Console.WriteLine("3-Autumn Jacket");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            if (option == 1)
                            {
                                var jacket = new WinterJacket();
                                user._cart.Add(jacket);
                            }
                            break;
                        case 2:
                            if (option == 2)
                            {
                                var jacket = new SummerJacket();
                                user._cart.Add(jacket);
                            }

                            break;
                        case 3:
                            if (option == 3)
                            {
                                var jacket = new AutumnJacket();
                                user._cart.Add(jacket);
                            }
                            break;
                        default:
                            // code block
                            break;
                    }
                }
            

                var product = new WinterJacket() {_modelName = Console.ReadLine() };

                 
                Console.WriteLine("Do you want to view your cart?");
                if (Console.ReadLine().ToLower() == "yes") { 
                    foreach (var item in user._cart)
                        Console.WriteLine(item.brand);
                        Console.WriteLine(user._cart);
                }


                else
                    Console.WriteLine("Suck a duck!");
            }
        }
    }
}

