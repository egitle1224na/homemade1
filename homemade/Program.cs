// Написать программу, которая из
// 1. имеющегося массива строк 
// 2. формирует массив из строк,длина которых меньше либо равна 3 символа.
//  Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. при решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] arrayString = { "5", "home", "123", "world5", "abcde456" };
void PrintArray(string[] arf)
{
    for (int i = 0; i < arf.Length; i++)
    {
        Console.Write($"{arf[i]} ");
    }
}

string[] FiltrArray(string[] oldArray)

{
    int sizeNewArray = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= 3) sizeNewArray++;
    }
    string[] arrayNew = new string[sizeNewArray];
    int j = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= 3)
        {
            arrayNew[j] = oldArray[i];
            j++;
        }
    }
    return arrayNew;
}
PrintArray(arrayString);
Console.WriteLine();
string[] arrayString2 = FiltrArray(arrayString);
PrintArray(arrayString2);
