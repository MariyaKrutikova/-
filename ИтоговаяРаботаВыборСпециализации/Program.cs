/*Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше или равна 3 символа.

1. ЗаДать начальны массив строк.
2. Посчитать количество строк в начальном массиве, подподает под условеи "меньше или равно 3 символа".
3. Задать новый пустой массив длиной равной полученому в п.2 колличеству строк.
4. Последовательно присвоить каждому значению нового массива значений начального массива, в которых меньше или 3 символа.
5. Вывести новый массив.*/

// Метод, задающий размерность массива
int GetDimention(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) & result > 0)
            break;
        else
            Console.WriteLine("Некорректные данные. Повторите ввод.");
    }
    return result;
}

// Метод, задающий массив. Элементы массива вводятся пользователем с клавиатуры
string[] GetArray(int dimention)
{
    int i = 0;
    string[] GetArray = new string[dimention];
    for (i = 0; i < dimention; i++)
        {
            Console.WriteLine($"Введите {i}-й элемент массива: ");
            GetArray[i] = Console.ReadLine();
        }
    return GetArray;
}


// Подсчет колличества строк массива, в которых три или меньше символов.
int GetCountOfStrings(string[] array, int dimention)
{
    int count = 0;
    int i = 0;
    for (i = 0; i < dimention; i++)
    {
        if (array[i].Length <= 3)
            {
                count = count + 1;
            }
    }
    return count;
}
 
//Формируем массив строк, длина которых меньше или равна 3 символа
string[] GetNewStringArray(string[] StartStringArray, int dimention, int count)
{
    string[] NewStringArray = new string[count];
    int n = -1;
    int i = 0;
    int j = 0;
    for (i = 0; i < count; i++)
        for (j = n + 1; j < dimention; j++)
        {
            if (StartStringArray[j].Length <= 3)
            {
                NewStringArray[i] = StartStringArray[j];
                n = j;
                break;
            }
            
        }
        return NewStringArray;
}



int dimention = GetDimention("Укажите размерность массива: "); //Задаем размерности начального массива строк
string[] StartStringArray = GetArray(dimention); //Задаем начальный массив

Console.WriteLine();
Console.WriteLine("Начальный массив:");
Console.WriteLine($"[{string.Join(", ", StartStringArray)}]"); // Выводим заданный начальный массив

int count = GetCountOfStrings(StartStringArray, dimention); //Определяем количество строк в заданном начальном массиве, в которых 3 и менее символов
Console.WriteLine();
Console.WriteLine($"Количество строк, в которых 3 и менее символа: {count}");//Выводим количество строк заданного начальном массиве, в которых 3 и менее символа

string[] NewStringArray = GetNewStringArray(StartStringArray, dimention, count);//Формируем массив строк, длина которых меньше или равна 3 символа.
Console.WriteLine();
Console.WriteLine("Новый массив:");
Console.WriteLine($"[{string.Join(", ", NewStringArray)}]"); // Выводим новый массив


