
string[] FilterStrings(string[] originalArray)
{
    int count = 0;
    // Подсчет количества строк, длина которых не превышает 3 символов
    foreach (var item in originalArray)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }

    // Создание нового массива с подходящими строками
    string[] newArray = new string[count];
    int index = 0;
    foreach (var item in originalArray)
    {
        if (item.Length <= 3)
        {
            newArray[index++] = item;
        }
    }

    return newArray;
}


// Ввод массива строк
Console.WriteLine("Введите строки массива через пробел:");
string input = Console.ReadLine();
string[] originalArray = input.Split(' ');

// Формирование нового массива строк
string[] newArray = FilterStrings(originalArray);

// Вывод нового массива строк
Console.WriteLine("Новый массив строк:");
foreach (var item in newArray)
{
    Console.Write(item + " ");
}
System.Console.WriteLine();
