using System;

class Program
{
    static void Main()
    {
        System.Console.Write("Введите свое имя:");
        name = Console.ReadLine();
        System.Console.WriteLine("Привет, [0]", name);
        System.Console.WriteLine(DayOfWeek);
        System.Console.Write("Хотите продолжить?(y/n)");
        string vopros = Console.ReadLine();
        if (vopros == y)
        {
            System.Console.WriteLine("Good!");
        }
        else
        {
            System.Console.WriteLine("Прощайте!");
        }
    }
}