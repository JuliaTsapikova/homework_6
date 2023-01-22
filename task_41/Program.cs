// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int getCountOfNumbers(int[] Array)
{
    int count = 0;
    for(int i = 0; i < Array.Length; i++)
    {
        if(Array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

Console.WriteLine("Введите через запятую целые числа и нажмите Enter");
string[] numbers = Console.ReadLine()!.Split(new char[] { ',' });
int[] Array = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    Array[i] = int.Parse(numbers[i]);
}
int count = getCountOfNumbers(Array);
Console.WriteLine($"Количество чисел больше 0 равно: {count}");