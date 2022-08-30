//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int firstValue = Prompt("Введите первое число > ");
int secondValue = Prompt("Введите второе число > ");
int thirdValue = Prompt("Введите третье число > ");
if (firstValue > secondValue && firstValue > thirdValue)
{
    System.Console.WriteLine("max = firstValue");
} else if (secondValue > thirdValue && secondValue > firstValue)
{
    System.Console.WriteLine("max = secondValue");
} else if (thirdValue > firstValue && thirdValue > secondValue)
{
    System.Console.WriteLine("max = thirdValue");
}
