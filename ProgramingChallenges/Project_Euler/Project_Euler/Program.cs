using System;

namespace Project_Euler
{
    class Program
    {

        static void Main(string[] args)
        {
            int euler;
        etykieta:
            Console.WriteLine("With Euler do you want to run? \nEnter number from 1 to 10. Type 0 to end.");


            string temp = Console.ReadLine();
            bool check = Int32.TryParse(temp, out euler);

            switch (euler)
            {
                case 0:
                    break;
                case 1:
                    Euler1.Calculate();
                    goto etykieta;
                case 2:
                    Euler2.Calculate();
                    goto etykieta;
                case 3:
                    Euler3.Calculate();
                    goto etykieta;
                case 4:
                    Euler4.Calculate();
                    goto etykieta;
                case 5:
                    Euler5.Calculate();
                    goto etykieta;
                case 6:
                    Euler6.Calculate();
                    goto etykieta;
                case 7:
                    Euler7.Calculate();
                    goto etykieta;
                case 8:
                    Euler8.Calculate();
                    goto etykieta;
                case 9:
                    Euler9.Calculate();
                    goto etykieta;
                case 10:
                    Euler10.Calculate();
                    goto etykieta;
                case 11:
                    Euler11.Calculate();
                    goto etykieta;
                case 12:
                    Euler12.Calculate();
                    goto etykieta;

                default:
                    Console.WriteLine("You have entered wrong number.");
                    goto etykieta;

            }







        }
    }
}
