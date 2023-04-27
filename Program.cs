string[] InputArray() // Функция создания массива строк, наполнение задается пользователем с консоли
{
    Console.WriteLine("");

    Console.Write("Введите значение данных через запятую");

    Console.WriteLine("");

    string str = Console.ReadLine()!;
    string[] array = str.Split(',');

    string[] result = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        string temp = array[i].Trim();

        result[i] = temp;

    }

    return result;
}

void PrintArray(string[] arr) // Функция вывода массива в консоль через запятую
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {

        Console.Write(arr[position]);

        if (position != count - 1)
            Console.Write(", ");
        position++;
    }
    Console.WriteLine();
}

string[] NewArray(string[] input) // Функция возврата нового массива, заполненного значениями <= 3
{
    int count = 0;

    for (int i = 0; i < input.Length; i++) 
    {
        if (input[i].Length <= 3)
            count++;
    }

    if (count == 0)
    {
        string[] result = new string[1]; 
        result[0] = "no_rezult";
        return result;

    }
    else
    {
        string[] result = new string[count]; 
        int indexResult = 0;

        for (int i = 0; i < input.Length; i++) 
        {
            if (input[i].Length <= 3)
            {
                result[indexResult] = input[i];
                indexResult++;
            }
        }
        return result;
    }
}

string[] array = InputArray();

string[] result = NewArray (array);

// Вывод результата в консоль
if (result[0] == "no_rezult") 
{
    Console.WriteLine("");
    Console.WriteLine("Трехзначных элементов в значениях не найдено");
    Console.WriteLine("");
}
else // Вывод зеленого сообщения с массивом элементов, соответствующих условию
{
    Console.WriteLine("");
    Console.WriteLine("Найденные трехзначные элементы:");
    PrintArray(result);
}