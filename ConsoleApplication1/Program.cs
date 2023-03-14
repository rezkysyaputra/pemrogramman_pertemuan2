using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateConsolApp
{
    class Program
    {
        static void Main(string[] args) {
            Console.Title ="Switch case App";
            Console.Write("Pilih operasi apa yang ingin di terjemahkan \n 1. '+' \n 2. '-' \n 3. 'x' \n 4. '/' \n");
            char Operasi = char.Parse(Console.ReadLine());

            if(Operasi != 1)
            switch (Operasi)
            {
                case '1': 
                    Console.Write("Ini operasi penjumlahan");
                    break;
                case '2':
                    Console.Write("Ini operasi penjumlahan");
                    break;
                case '3':
                    Console.Write("Ini operasi penjumlahan");
                    break;
                case '4':
                    Console.Write("Ini operasi penjumlahan");
                    break;
            }

            Console.ReadLine();
        }
    
       
        }    
    }
      

 
