using Tyuiu.ReutovZA.Sprint3.Task4.V4.Lib;

namespace Tyuiu.ReutovZA.Sprint3.Task4.V4;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Реутов З.А | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла foreach.                                           *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Реутов Захар Александрович | ПКТб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Используя цикл foreach удалить из строки все буквы j в строке:          *");
        Console.WriteLine("* plkjjdw cvjkl                                                           *");
        Console.WriteLine("***************************************************************************");

        string str = "plkjjdw cvjkl";

        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("* Строка: " + str);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.DeleteCharFromStr(str);
        Console.WriteLine("Результат: " + res);

        Console.ReadKey();
    }
}