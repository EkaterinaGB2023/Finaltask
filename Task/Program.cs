/* Программа, которая из имеющегося массива строк формирует новый массив 
из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив запрашиваем у пользователя. 
*/

int Prompt(string message) 
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

string[] FillArray(int size)
{
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} значение массива: ");
        result[i] = Console.ReadLine() ?? "";
    }
    return result;
}

string[] DeleteLongElements(string[] array)
{
    int count = 0;  // счетчик для определения кол-ва элементов длиной не более трех символов
    int[] positions = new int[array.Length]; // массив с индексами элементов не более трех символов
    for (int i = 0; i < array.Length; i++)// цикл для подсчета кол-ва элементов длиной не более трех символов и запоминания их индексов
    {
        if (array[i].Length <= 3)
        {
            positions[count] = i;
            count++;
        }
    }
    string[] resultArray = new string[count];
    for (int j = 0; j < count; j++)
    {
        resultArray[j] = array[positions[j]];
    }
    return resultArray;
}

Console.Clear();
int length = Prompt("Введите длину массива, который Вы хотете проверить: ");
string[] myArray = FillArray(length);
string[] newArray = DeleteLongElements(myArray);
Console.Write($"[{String.Join(",", myArray)}] -> ");
Console.Write($"[{String.Join(",", newArray)}]");
