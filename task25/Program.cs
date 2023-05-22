// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Pow(int A, int B)
{
    int pow = A;
    for (int i = 1; i < B; i++)
    {
        pow = A * pow;
    }
    return pow;
}

System.Console.WriteLine("Vvedite chislo A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Vvedite chislo B: ");
int B = Convert.ToInt32(Console.ReadLine());
int Pow1 = Pow(A, B);
System.Console.WriteLine($"{A} v stepeny {B} = {Pow1}");