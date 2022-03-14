using System;
using Class_Practice.Models;
namespace Class_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = GetInputInt("Nece eded book daxil edeceksiniz?", 0);

            Book[] Books = new Book[length];

            for (int i = 0; i < length; i++)
            {
                double price = GetInputDouble($"{i + 1}.ci Bookun qiymetini daxil edin: ", 5);

                int No = GetInputInt($"{i + 1}.ci Bookun nomresi: ", 1);
                string name = GetInputStr($"{i + 1}.ci Bookun adi: ", 1);

                string genre = GetInputStr($"{i + 1}.ci Bookun janri: ", 1);

                int count = GetInputInt($"{i + 1}.ci Bookun sayi: ", 1);



                Books[i] = new Book(genre, name, No, price)
                {
                    count = count

                };
            }

            foreach (Book book in Books)
            {
                book.GetInfo();
            }
            Console.Write("Input 1 Sort the books for price\n");
            Console.Write("Input 2 View books\n");
            Console.Write("Input 0 Sonlandir\n");
            Console.Write("Sechim ele: ");
            choice = Convert.ToInt32(Console.ReadLine());









            static double GetInputDouble(string name, double min, double max = double.MaxValue)
            {
                double input;
                do
                {

                    Console.WriteLine(name);
                    input = Convert.ToDouble(Console.ReadLine());
                } while (input < min || input > max);

                return input;
            }

            static int GetInputInt(string name, int min, int max = int.MaxValue)
            {
                int input;
                do
                {
                    Console.WriteLine(name);
                    input = Convert.ToInt32(Console.ReadLine());
                } while (input < min || input > max);

                return input;
            }



            static string GetInputStr(string name, int min, int max = int.MaxValue)
            {
                string input;
                do
                {
                    Console.WriteLine(name);
                    input = Console.ReadLine();
                } while (input.Length < min || input.Length > max);

                return input;
            }
        }
    }
}
