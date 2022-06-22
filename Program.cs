using System;
class Program
{   //Вычислить произведение элементов одномерного массива (с применением рекурсии и без неё)
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int N;
        System.Console.WriteLine("Razmer massiva N");
        N = System.Convert.ToInt32(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++) array[i] = (i + 1) * 2;
        System.Console.WriteLine();
        Console.WriteLine(Sum(array));
        Console.WriteLine(Sum_rec(array, N - 1));
    }
    static int Sum(int[] a)
    {
        int b = 1;
        for (int i = 0; i < a.Length; i++) b *= a[i];
        return b;
    }
    static int Sum_rec(int[] a, int i, int b = 1)
    {
        if (i == 0) return b * a[i];
        else return Sum_rec(a, i - 1, (b * a[i]));
    }
}
