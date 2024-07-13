// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


static void Main()
{
z1();  
z2();
z3();
}

static void z1()
{
Console.Clear();

Console.WriteLine("Задание 1");

Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int NaturalNumber(int a, int b)
{
if (a == b) return a;
else
{
Console.Write($"{NaturalNumber(a, b - 1)}, ");
return b;
}
}

Console.WriteLine(NaturalNumber(m, n));
Console.ReadKey();
}

static void z2()
{
Console.Clear();

Console.WriteLine("Задание 2");

Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int a, int b)
{
if (a == 0) return b + 1;
if (a > 0 && b == 0) return Akkerman(a - 1, 1);
else return Akkerman(a - 1, Akkerman(a, b - 1));
}


Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");
Console.ReadKey();
}

static void z3()
{
Console.Clear();

Console.WriteLine("Задание 3");

int [] num = new int [5];

Random rand = new Random();

for(int i = 0; i < num.Length; i++)

{num[i] = rand.Next(1, 10);}

Console.WriteLine("Исходный массив ");

Console.WriteLine(string.Join (" ", num));

Console.WriteLine("Итоговый массив ");

void print(int[] A, int n)
{
if (n > 0)
{
Console.Write(A[n] + " ");
print(A, n - 1);
}
else Console.WriteLine(A[0]);
}

print(num, num.Length - 1);
Console.ReadKey();
}


Main();

