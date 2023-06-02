// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Console.ReadLine();

int Sum(string number);
{
    int sum = 0;
    for(int i = 1; i < number.Length; i++)
    {
        sum = sum + number[i];
    } 
    Console.WriteLine($"Сумма цифр числа  + {number} = {sum}");
    return sum;
}

int Sum(string number);
