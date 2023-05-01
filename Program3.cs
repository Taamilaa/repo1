

using System;

class Program

{

    static void Main()

    {

        // Оголошення масиву та встановлення його розміру

        double[] arr = { 1.2, -2, 3.5, 4, 5.3, -6.1, 7.2, 9 };

        // Введення значень A та B

        Console.Write("Введіть значення A: ");

        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть значення B: ");

        double B = Convert.ToDouble(Console.ReadLine());

        // Лічильники для кількості елементів та суми

        int countInRange = 0;

        double sumAfterMax = 0;

        // Максимальний елемент та його індекс

        double maxElement = arr[0];

        int maxIndex = 0;

        // Обхід масиву та виконання обчислень

        for (int i = 0; i < arr.Length; i++)

        {

            if (arr[i] >= A && arr[i] <= B)

            {

                countInRange++;

            }

            if (arr[i] > maxElement)

            {

                maxElement = arr[i];

                maxIndex = i;

            }

            if (i > maxIndex)

            {

                sumAfterMax += arr[i];

            }

        }

        // Виведення результатів

        Console.WriteLine("Кількість елементів у діапазоні від {0} до {1}: {2}", A, B, countInRange);

        Console.WriteLine("Сума елементів після максимального елемента: {0}", sumAfterMax);

        // Сортування елементів за спаданням модулів

        Array.Sort(arr, (x, y) => Math.Abs(y).CompareTo(Math.Abs(x)));

        Console.WriteLine("Елементи масиву упорядковані за спаданням модулів: ");

        foreach (var element in arr)

        {

            Console.WriteLine(element);

        }

    }

}

