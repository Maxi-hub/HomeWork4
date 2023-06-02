// Программa, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];   


void RandomNumber(int[] array)  
{
    Console.WriteLine("Введите числа");
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

RandomNumber(array);  
Console.WriteLine("[" + String.Join (", ", array) + "]");


