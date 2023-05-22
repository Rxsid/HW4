// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Sum(int number)
{
int count = 0;
int ost = 0;
while (number > 0)
{
ost = number/10;
number %= 10;
count = count + number;
number = ost;
}
return count;
}

System.Console.WriteLine("Vvedite chislo: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = Sum(num);
System.Console.WriteLine($"Summa cifr v chisle {num} = {count}");
