// Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int[] numbers = new int[2];
Console.WriteLine("Введите два числа");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

double level = Math.Pow(numbers[0], numbers[1]);
Console.WriteLine($"Число {numbers[0]} в степени {numbers[1]} = " + level);
