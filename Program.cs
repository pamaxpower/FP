/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями,
 лучше обойтись исключительно массивами
*/

Console.Clear();

Console.WriteLine("Введите количество элементов массива");
int elementsCount = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[elementsCount];

for (int i = 0; i < Array.Length; i++)                                      // Заполняем массив с клавиатуры
{
    Console.Write($"Введите элемент массива под индексом {i}:\t");
    Array[i] = Convert.ToString(Console.ReadLine());
}
Console.Clear();

Console.WriteLine($"Заданный массив: {String.Join(",", Array)}");           // Вывод первоначального массив
string[] newArray = FillNewArray(Array);                                    
Console.WriteLine($"Полученный массив: {String.Join(" ", newArray)}");      // Вывод нового массива

string[] FillNewArray (string[] arr)                                        // Заполнение нового массива
{
    string[] newArray = new string[Array.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) 
        {
            newArray[count] = arr[i];
            count++;
        }
    }
    return newArray;
}