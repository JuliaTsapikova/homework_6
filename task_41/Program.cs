// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int getUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int [] Array(int M)
{   int[] result = new int[M];
    for(int i = 0; i < M; i++)
    {
        Console.WriteLine($"Введите число: [{i}]");
        result[i] = int.Parse(Console.ReadLine()!);
    }
    return result;
}

void printArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.WriteLine(" ");
        }
    }
}

int getCountOfNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}
int M = getUserData("Введите длину массива: ");
int[] array = Array(M);
printArray(array);
int count = getCountOfNumbers(array);
Console.WriteLine($"Количество чисел больше 0 равно: {count}");