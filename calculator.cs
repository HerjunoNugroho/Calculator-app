using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            Console.WriteLine("Pilih Menu Calculator :");
            
            Console.WriteLine();
			
            Console.WriteLine("1. Pemanbahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            
            Console.WriteLine();
            
            Console.Write("Input nomor menu [1..4] : ");
            int nomor = int.Parse(Console.ReadLine());
            
            Console.WriteLine();

			if(nomor==1)
			{
				Console.Write("Input Nilai a = ");
				int a = int.Parse(Console.ReadLine());
				Console.Write("Input Nilai b = ");
				int b = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();
                Console.WriteLine("hasil penjumlahan " + a + " + " + b + " = " + penambahan(a, b));
			}
			else if(nomor==2)
			{
				Console.Write("Input Nilai a = ");
				int a = int.Parse(Console.ReadLine());
				Console.Write("Input Nilai b = ");
				int b = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();
                Console.WriteLine("hasil pengurangan: " + a + " - " + b + " = " + pengurangan(a, b));
            }
			else if(nomor==3)
			{
				Console.Write("Input Nilai a = ");
				int a = int.Parse(Console.ReadLine());
				Console.Write("Input Nilai b = ");
				int b = Convert.ToInt32(Console.ReadLine());
				 Console.WriteLine();
                Console.WriteLine("hasil perkalian: " + a + " * " + b + " = " + perkalian(a, b));
            }
			else if(nomor==4)
			{
				Console.Write("Input Nilai a = ");
				int a = int.Parse(Console.ReadLine());
				Console.Write("Input Nilai b = ");
				int b = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();
                Console.WriteLine("hasil pembagian: " + a + " / " + b + " = " + pembagian(a, b));
			}
			else
            {
                Console.WriteLine("Maaf, Menu yang Anda pilih tidak tersedia");
            }
            Console.WriteLine("\nTekan Sembarang Untuk Keluar.");
            Console.ReadKey();
        }
		static int penambahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}