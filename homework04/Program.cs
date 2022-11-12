Console.WriteLine("Введите целое число! ");
int count = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < count + 1; i++)
{
    if (i % 2 == 0)
        Console.Write(i);
}
