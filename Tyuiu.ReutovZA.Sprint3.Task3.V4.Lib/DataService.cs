namespace Tyuiu.ReutovZA.Sprint3.Task4.V4.Lib;

public class DataService
{
    public string DeleteCharFromStr(string value)
    {
        string result = "";
        // Используем цикл foreach для перебора каждого символа в строке
        foreach (char c in value)
        {
            if (c != 'j')
            {
                result += c;
            }
        }
        return result;
    }
}