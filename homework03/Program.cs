Console.WriteLine("Введите число 1");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num_b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int num_c = Convert.ToInt32(Console.ReadLine());

int max = num_a;

if (num_a > max)
    max = num_a;
if (num_b > max)
    max = num_b;

Console.Write($"max = {max}");
