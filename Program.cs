//1) Написать утилиту для множесвенного открытия вкладок гугл хром, пользотель вводит число сколько их отрыть, утилита итерированно их порождает 
using System.Diagnostics;

int amountOfBlanks = int.Parse(Console.ReadLine());
string configs = "--start-fullscreen";
int i = 1;


while (i <= amountOfBlanks)
{
    string frameUrl = $"https://www.google.ru/search?q=число{i}";

    Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"", $"{configs} {frameUrl}");
    i++;
}
