Console.WriteLine("Введите число 'a'");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 'b");
int num_b = Convert.ToInt32(Console.ReadLine());
if (num_a > num_b)
{
    Console.WriteLine($"max = {num_a}");
}
if (num_b > num_a)
{
    Console.WriteLine($"max = {num_b}");
}
