//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string msg)
{
 Console.WriteLine(msg);
 string line = Console.ReadLine();
 int number = int.Parse(line);
 return number;
}
int number = ReadInt("Введите ваше число => ");
int SumDigital(int number)
    {
    int sumDigital = 0;
    while(number > 0)
    {       
        int numb = number % 10; 
        sumDigital = sumDigital + numb ;
        number = number / 10;
    }
        return sumDigital;
    }
int sumD = SumDigital(number);
Console.WriteLine($"Сумма цифр вашего числа равна = {sumD}");

