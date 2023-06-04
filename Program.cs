//-------------------------------------------------
//-------------Начало программы--------------------
//------------------------------------------------- 
//--------------- Основной код --------------------
//-------------------------------------------------
Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int n = int.Parse(Console.ReadLine());

string[] inputArray = new string[n];

Console.WriteLine("Введите строки:");
    for (int i = 0; i < n; i++)
        {
            inputArray[i] = Console.ReadLine();
        }

string[] filteredArray = FilterArray(inputArray);

Console.WriteLine("Отфильтрованный массив строк:");
    foreach (string str in filteredArray)
    {
        Console.WriteLine(str);
    }

//----------------------------------------------------
//---------------- Решение задачи --------------------
//----------------------------------------------------
string[] FilterArray(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

string[] filteredArray = new string[count];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            filteredArray[index] = array[i];
            index++;
        }
    }
    return filteredArray;
}
//----------------------------------------------------
//------------- Конец программы ----------------------
//----------------------------------------------------