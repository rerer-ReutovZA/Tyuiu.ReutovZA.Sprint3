using Tyuiu.ReutovZA.Sprint3.Task7.V24.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Реутов З.А| ПКТб-25-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #3                                                            *");
        Console.WriteLine("* Тема:                                                                *");
        Console.WriteLine("* Задание #7                                                           *");
        Console.WriteLine("* Вариант #24                                                          *");
        Console.WriteLine("* Выполнил: Реутов З.А| ПКТб-25-1                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        int startValue = -5000;
        int stopValue = 500;

        Console.WriteLine("старт шага:" + startValue);
        Console.WriteLine("конец шага:" + stopValue);

        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] valueArray;
        valueArray = new double[len];

        valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine("+-------+-------+");
        Console.WriteLine("+   X   |  f(x) +");
        Console.WriteLine("+-------+-------+");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}   |   {1, 5:f2}  |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+-------+-------+");
        Console.ReadKey();

    }
}