int CalculateRoot(int number)
{
    int sum = 0;
    do
    {
        sum += number % 10;
        number = number / 10;
    } while (number > 0);

    return sum;
}

int count = 0;
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

while (a != b)
{
    count++;
    int root1 = CalculateRoot(a);
    int root2 = CalculateRoot(b);
    if (a > b)
    {
        a -= Math.Min(root1, root2);
    }
    else
    {
        b -= Math.Min(root1, root2);
    }
}
Console.WriteLine($"a = {a} b = {b}");
Console.WriteLine($"Количество шагов = {count}");

Console.ReadLine();