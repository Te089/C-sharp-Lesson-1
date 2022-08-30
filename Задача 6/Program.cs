//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int firstValue = Prompt("Введите первое число > ");
if (firstValue % 2 == 0)
{
    System.Console.WriteLine("-> да, чётное");
} else
{
    System.Console.WriteLine("-> нет, не чётное");
}
