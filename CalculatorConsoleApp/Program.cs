using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            int a, b, choice;

            do
            {
                Console.WriteLine("Pilih menu calculator");
                Console.WriteLine();
                Console.WriteLine("1. Penambahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian");
                Console.WriteLine();
                Console.WriteLine("Input nomor menu [1..4]: ");

                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                    Console.WriteLine();
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Input nilai a = ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Input nilai b = ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"Hasil Penambahan {a} + {b} = {a + b}"); 
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.Write("Input nilai a = ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Input nilai b = ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"Hasil Pengurangan {a} - {b} = {a - b}");
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.Write("Input nilai a = ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Input nilai b = ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"Hasil Perkalian {a} * {b} = {a * b}");
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.Write("Input nilai a = ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Input nilai b = ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"Hasil Pembagian {a} / {b} = {a / b}");
                        break;
                }

                Console.WriteLine("\nTekan sembarang key untuk keluar");
                Console.ReadKey();
                return;
            } while (choice != 4);

        }
    }
}
