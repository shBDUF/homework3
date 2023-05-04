bool IsNumberPolindrom(int Number)
{
    int temp = Number, rebmun, sum = 0;
    while (Convert.ToBoolean(Number))
    {
        rebmun = Number % 10;
        Number = Number / 10;
        sum = sum * 10 + rebmun;
    }
    Console.WriteLine("\n Перевёрнутое число: {0}", sum);
    if (temp == sum)
    {
        Console.WriteLine("\n Число {0} полиндром \n",temp);
        return true;
    }
    else
    {
        Console.WriteLine("\n Число {0} не полиндром \n",temp);
        return false;
    }
}

Console.WriteLine("\n Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num>9999 && num<=99999)
{
    IsNumberPolindrom(num);
}
else{
    Console.Write(" \n Попробуй ещё раз \n ");
}