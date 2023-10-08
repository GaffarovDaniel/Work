/*
Задача: Написать программу, которая из имеющегося массива 
строк формирует новый массив из строк, длина которых
 меньше, либо равна 3 символам. Первоначальный массив можно ввести 
 с клавиатуры, либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
 исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/



string[] Subarray(string[] array, int lenght)
{
    string result = string.Empty; // пустая строка
    string array_i = string.Empty; // временное переменная
    for (int i = 0; i < array.Length; i++)
    {
        array_i = array[i];
        if (array_i.Length <= lenght)
        {
            result += " " + array_i;
        }
        array_i = string.Empty;
    }
    string[] subarray = result.Split();
    return subarray;
}


Console.Write("Введите количесвто элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] s =  new string[n];

for (int i = 0; i < n ; i++)
{
    Console.Write("Введите что-захотите");
}