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
        