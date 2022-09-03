Console.WriteLine("Введите три числа, ");
Console.WriteLine("какое из них имеет максимальное значение.");
Console.Write("Введите первое число нажмите ENTER:");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число нажмите ENTER:");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число нажмите ENTER:");
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_2 > max)
{
    max = num_2;
}

if (num_3 > max) ;
{
    max = num_3;
}

Console.WriteLine("Наибольшее из введённых чисел ->" + max);
