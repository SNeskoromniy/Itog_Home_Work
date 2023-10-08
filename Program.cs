/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Clear();
// Формируем массив из строк
//string[] stringArray = { "1234", "1567", "-2", "computer science"};
//string[] stringArray = {"Russia", "Denmark", "Kazan"};
string[] stringArray = {"Hello", "2", "world", ":-)"};

strArrNew(stringArray);
printArray(strArrNew(stringArray));


//Метод вывода массива строк
void printArray(string[] stringArray)
{
    Console.Write("Новый мвссив: ");
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"”{stringArray[i]}”");
        if (i != stringArray.Length - 1) Console.Write(",");
    }
    Console.Write("]");
}

string[] strArrNew(string[] stringArray)
{
    //считаем размер массива строк с элементами <= 3 символов
    int n = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            n++;
    }
    //создаем новый массив строк <= 3 символов
    string[] rezult = new string[n]; 
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            rezult[j] = stringArray[i];
            j++;
        }
    }
    return rezult;
}
