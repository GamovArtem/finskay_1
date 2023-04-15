Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());  // Ввод числа
int remainder = num % 2;                        // Остаток

if(num != 0)                                    // Проверка на Маслова
{
    switch (remainder)
    {
        case 0:Console.Write("Ваше число четное");break;
        case 1:Console.Write("Ваше число не четное");break;
    }
}
else
{
    Console.WriteLine("Вы маслов?");
}
