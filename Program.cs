using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] ratings = { 95, 88, 76, 59, 47, 100, 68, 85, 55, 91 };

        // Запит 1: Кількість студентів із рейтингом < 60
        int lowRatingCount = ratings.Count(r => r < 60);
        Console.WriteLine($"Кількість студентів із рейтингом < 60: {lowRatingCount}");

        // Запит 2: Кількість студентів із рейтингом > 90
        int highRatingCount = ratings.Count(r => r > 90);
        Console.WriteLine($"Кількість студентів із рейтингом > 90: {highRatingCount}");
    }
}
