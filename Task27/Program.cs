// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetLength() 
{     
    Console.WriteLine("Введите число: ");
    int length = Convert.ToInt32(Console.ReadLine());
    return length; 
} 

int Sum(int length)
{
    int sum = 0;
    while (length > 0)
    {
        sum += length % 10;
        length = length/10;

    }
    return sum;
}

int number = GetLength(); 
int result = Sum(number);

Console.WriteLine("Сумма цифрр в числе: " + result);

    
