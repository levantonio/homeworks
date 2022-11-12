Console.WriteLine("Введите целое число");
int num_a = Convert.ToInt32(Console.ReadLine());
if (num_a % 2 == 0)
{
    Console.WriteLine("да");
}
else if (num_a != 0)
{
    Console.WriteLine("нет");
}
