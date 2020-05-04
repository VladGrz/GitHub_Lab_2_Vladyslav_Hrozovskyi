using System;

namespace Lab_2
{
    public class Program
    {
        static void Way(char a)
        {
            switch (a)
            {
                case '1': Console.WriteLine("Початкова зупинка маршруту №1 - Залiзничний вокзал, кiнцева зупинка - вул. Пасiчна."); break;
                case '2': Console.WriteLine("Початкова зупинка маршруту №2 - вул. Пасiчна, кiнцева зупинка - вул. Коновальця(Музей Труша)."); break;
                case '3': Console.WriteLine("Початкова зупинка маршруту №3 - пл. Соборна, кiнцева зупинка - Аквапарк."); break;
                case '4': Console.WriteLine("Початкова зупинка маршруту №4 - Залiзничний вокзал, кiнцева зупинка - вул. Вернадського."); break;
                case '5': Console.WriteLine("Початкова зупинка маршруту №5 - вул. Миколайчука, кiнцева зупинка - вул. Коновальця."); break;
                case '6': Console.WriteLine("Початкова зупинка маршруту №6 - вул. Миколайчука, кiнцева зупинка - вул. Клепарiвська."); break;
                case '7': Console.WriteLine("Початкова зупинка маршруту №7 - Погулянка, кiнцева зупинка - Церква святої Анни."); break;
                case '8': Console.WriteLine("Початкова зупинка маршруту №8 - пл. Соборна, кiнцева зупинка - вул. Вернадського."); break;
                case '9': Console.WriteLine("Початкова зупинка маршруту №9 - Залiзничний вокзал, кiнцева зупинка - вул. Торф'яна."); break;
            }

        }
        static void Function(double a, double b, double dx)
        {
            double y;
            Console.WriteLine("__________________________________\n|        x        |       y      |\n");
            while (a <= b)
            {
                y = Math.Log(a);
                Console.WriteLine("----------------------------------\n|       {0:F2}      |     {1:F2}     |\n", a, y);
                a += dx;
            }
        }

        static public int suma(int[] arr)
        {
            int indexNull1 = 0, indexNull2 = 0, sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    indexNull1 = i;
                    break;
                }
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == 0)
                {
                    indexNull2 = i;
                    break;
                }
            }
            for (int i = indexNull1 + 1; i < indexNull2; i++)
            {
                sum += Math.Abs(arr[i]);
            }
            Console.WriteLine("Cума модулiв елементiв масиву розташованих мiж першим та останнiм нульовим елементом: {0:D}", sum);
            return sum;
        }
        static public int maxElement(int[] arr)
        {
            int max = arr[0], num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    num = i;
                }
            }
            Console.WriteLine("Номер максимального елемента масиву: " + num);
            return num;
        }
        static void randomArray(int[] arr)
        {
            Random arrRand = new Random();
            int min = -100, max = 100;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arrRand.Next(min, max);
                Console.WriteLine("a[{0:D}] = {1:D}", i, arr[i]);
            }
        }
        static void randomMatrica(int[,] arr)
        {
            Random arrRand = new Random();
            int min = -100, max = 100;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = arrRand.Next(min, max);
                    Console.Write(String.Format("{0,9}", arr[i, j]));
                }
                Console.Write("\n");
            }
        }
        static void Matrica(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("a[{0:D}]: ", i);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ваша матриця: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,9}", arr[i, j]));
                }
                Console.Write("\n");
            }
        }
        static void sumMaxElLine(int[,] arr)
        {
            int sum = 0, maxel;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                maxel = arr[i, 0];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > maxel) maxel = arr[i, j];
                }
                sum += maxel;

            }
            Console.WriteLine("Сума найбiльших елементiв рядкiв матрицi: " + sum);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть номер завдання.");
            int k;
            k = int.Parse(Console.ReadLine());
            if (k == 1)
            {
                Console.WriteLine("Введiть номер маршруту.");
                char marshrut;
                marshrut = (char)Console.Read();
                Way(marshrut);
            }
            else if (k == 2)
            {
                double a, b, dx;
                Console.WriteLine("Введiть перше значення.");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введiть друге значення.");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введiть крок.");
                dx = double.Parse(Console.ReadLine());
                Function(a, b, dx);
            }
            else if (k == 3)
            {
                Console.WriteLine("Бажаєте виконати програму вводячи масив iз клавiатури?(введiть 0) Чи заповнити масив псевдовипадковими числами?(введiть - 1)");
                int c;
                c = int.Parse(Console.ReadLine());
                if (c == 0)
                {
                    const int n = 6;
                    Console.WriteLine("Введiть числа для заповнення масиву:");
                    int[] masiv = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("a[{0:D}]: ", i);
                        masiv[i] = int.Parse(Console.ReadLine());
                    }
                    maxElement(masiv);
                    suma(masiv);
                }
                else if (c == 1)
                {
                    const int l = 6;
                    int[] mas = new int[l];
                    randomArray(mas);
                    maxElement(mas);
                    suma(mas);
                }

            }
            else if (k == 5)
            {
                Console.WriteLine("Бажаєте виконати програму вводячи матрицю iз клавiатури?(введiть 0) Чи заповнити матрицю псевдовипадковими числами?(введiть - 1)");
                int key;
                key = int.Parse(Console.ReadLine());
                if (key == 0)
                {
                    const int n = 4, m = 5;
                    int[,] matrica = new int[n, m];
                    Matrica(matrica);
                    sumMaxElLine(matrica);
                }
                if (key == 1)
                {
                    const int n = 4, m = 5;
                    int[,] rmatrica = new int[n, m];
                    randomMatrica(rmatrica);
                    sumMaxElLine(rmatrica);
                }
            }
        }
    }
}
