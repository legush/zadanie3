using System;

namespace zadanie3
{
    class Program
    {
        //1
        static void a(int[] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++) {

                arr[i] = -23 + rand.Next() % 15;
                Console.Write(arr[i] + " ");
            }

            int min = arr[0];
            int mod;

            for (int i = 0; i < arr.Length; i++) {

                mod = arr[i];

                if (min < 0) min *= -1;
                if (mod < 0) mod *= -1;
                if (mod < min) min = mod;
            }
            Console.WriteLine("\n" + "минимальный по модулю элемент массива: " + (min) + "\n");
        }

        //2
        static void b (int[] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = -10 + rand.Next() % 10;
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            int n = 0;
            int l = 0;
          
            Console.Write("уникальные элементы массива:" + " ");

            for (int i = 0; i < arr.Length; i++) {
                int c = 0;

                for (int j = 0; j < arr.Length; j++) {
                    if (arr[j] == arr[i]) {
                        c++;
                        n = arr[j];
                    }
                }

                if (c == 1) {
                    Console.Write(n + " ");
                    l++;
                }
                else n = 0;
            }
            Console.WriteLine("\n");
            if (l == 0) Console.WriteLine("уникальных элементов массива нет" + "\n");
        }

        //3
        static void c(int[] arr)
        {
            Random rand = new Random();

            int[] ar = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -5 + rand.Next() % 15;
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.Write("положительные элементы массива:"+ " ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0) ar[i] = arr[i];
                else continue;
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("№1 " + "\n");
            int[] arr = new int[5];
            a(arr);

            Console.WriteLine("№2 " + "\n");
            b(arr);

            Console.WriteLine("№3 " + "\n");
            c(arr);
        }
    }
}