using System;

namespace Project_Euler
{
    class Program
    {
        private static byte[] bytes;

        static void Main(string[] args)
        {
            Console.WriteLine("With Euler do you want to run? \nEnter number from 1 to 9.");
            int euler; 
            etykieta:
            string temp = Console.ReadLine();
            bool check = Int32.TryParse(temp, out euler);
            
                switch (euler)
                {
                    case 1:
                        Euler1.Calculate();
                        break;
                    case 2:
                        Euler2.Calculate();
                        break;
                    case 3:
                        Euler3.Calculate();
                        break;
                    case 4:
                        Euler4.Calculate();
                        break;
                    case 5:
                        Euler5.Calculate();
                        break;
                    case 6:
                        Euler6.Calculate();
                        break;
                    case 7:
                        Euler7.Calculate();
                        break;
                    case 8:
                        Euler8.Calculate();
                        break;
                    case 9:
                        Euler9.Calculate();
                        break;

                    default:
                        Console.WriteLine("Enter number from 1 to 9, please.");
                        goto etykieta;

                }

            
           

            

        }
    }
}
