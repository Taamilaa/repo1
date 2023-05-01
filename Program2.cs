using System;
using System.IO;

class Program

{
    static void Main(string[] args)

    {

        int n = 100; // максимальне число для перевірки на простоту
        string fileName = "primes.txt"; // назва файлу для запису простих чисел


        // Відкриваємо файл для запису
        StreamWriter sw = new StreamWriter(fileName);

        for (int i = 2; i <= n; i++)

        {

            bool isPrime = true;
            for (int j = 2; j < i; j++)

            {
                if (i % j == 0)

                {

                    isPrime = false;
                    break;

                }

            }
            if (isPrime)
            {
                sw.WriteLine(i); // записуємо просте число у файл
            }
        }

        // Закриваємо файл
        sw.Close();
        Console.WriteLine($"Прості числа від 2 до {n} були записані у файл {fileName}.");

    }

}
