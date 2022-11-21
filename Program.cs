/* ==== Вид 1 (ничего не принимает, ничего не возвращает)
void Method1()
{
    Console.WriteLine("Awtor ...");
}
Method1();

Вид 2 (Что то принимает, ничего не возвращает)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

======= Вид 2а (Что то принимает, ничего не возвращает)
void Method2a(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++;
    }
}
Method2a(msg: "Текст сообщения", count: 4);

====== Вид 3 (Ничего не принимает, что то возвращает)

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

===== Вид 4 (Что то принимает, что то возвращает) (Через цик While)
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
    string result = Method4(4, "z ");
    Console.WriteLine(result);

====== Вид 4a (Что то принимает, что то возвращает) (Через цик For)

    string Method4(int count, string text)
{
        string result = string.Empty;
    for (int i = 0; i < count; i ++)
    {
        result = result + text;
    }
    return result;
}
    string result = Method4(4, "z ");
    Console.WriteLine(result);
   

    ====== (Пример Цикл for в цикле for.) (Таблица умножения)

     for (int i = 2; i <=10; i++)
     {
        for (int j = 2; j <=10; j++)
        {
            Console.WriteLine($"{i} * {j} = {i * j}");
        }
        Console.WriteLine();
     } 
     
     ===== Работа с текстом
     Дан текст. В тексте нужно все пробелы заенить черточками,
     маленькие буквы "к" заменить большими "К", 
     а большие "С" заменить маленикими "с".
     Ясна ли задача? (Много вопросов...)
     
     string text = "- Я думаю, сказал князь, улыбаясь, что, "
                 + "ежели ли вас послали место нашего милого Винценгероде,...";
// string s = "qwerty"
//             012345
// s[3] -> r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'с', 'С');
Console.WriteLine(newText);

====== Упорядочение данных внутри массива
*/
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)
{
    
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);