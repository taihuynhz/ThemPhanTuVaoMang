using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemPhanTuVaoMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] value = { 10, 4, 6, 7, 8, 0, 0, 0, 0, 0 };

            Console.Write("Nhap so can chen: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vi tri value can chen vao mang: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index <= 1 || index >= value.Length - 1)
            {
                Console.WriteLine("Khong chen duoc phan tu vao mang ");
            }
            else
            {
                Console.WriteLine("Mang truoc khi chen: ");
                for (int i = 0; i < 10; i++)
                {        
                    Console.Write(value[i] + " ");
                }
                Console.WriteLine();

                int[] newValue = new int[11];
                for (int i = 0; i < 11; i++)
                {
                    if (i < index - 1)
                        newValue[i] = value[i];
                    else if (i == index - 1)
                        newValue[i] = x;
                    else
                        newValue[i] = value[i - 1];
                }

                Console.WriteLine("Mang sau khi chen: ");
                for (int i = 0; i < 11; i++)
                {    
                    Console.Write(newValue[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
