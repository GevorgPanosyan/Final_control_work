using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
class Program
{
    static void Main()
    {
        //Вводим исходный массив с клавиатуры
        Console.WriteLine("Введите элементы массива через запятую");
        string input = Console.ReadLine();
        string[]array = input.Split(',');

        //Формируем новый массив из строк,длина которых <=3 символам
        string[] resultArray = GetShortStrings(array);

        // Выводим новый массив на экран
        Console.WriteLine("Новый массив:");
        foreach (string item in resultArray)
        {
            Console.WriteLine(item);
        }
    }
    static string[] GetShortStrings(string[] array)
    { 
        int count = 0;
        foreach (string item in array)
        {
            if (item.Lenght <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int index = 0;
        foreach (string item in array)
        {
            if (item.Lenght <=3)
            {
                resultArray[index] = item;
                index++;
            }
        }
        return resultArray;
        
    }
}