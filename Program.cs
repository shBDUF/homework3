// bool IsNumberPolindrom(int Number)
// {
//     int temp = Number, rebmun, sum = 0;
//     while (Convert.ToBoolean(Number))
//     {
//         rebmun = Number % 10;
//         Number = Number / 10;
//         sum = sum * 10 + rebmun;
//     }
//     Console.WriteLine("\n Перевёрнутое число: {0}", sum);
//     if (temp == sum)
//     {
//         Console.WriteLine("\n Число {0} полиндром \n",temp);
//         return true;
//     }
//     else
//     {
//         Console.WriteLine("\n Число {0} не полиндром \n",temp);
//         return false;
//     }
// }

// Console.WriteLine("\n Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num>9999 && num<=99999)
// {
//     IsNumberPolindrom(num);
// }
// else{
//     Console.Write(" \n Попробуй ещё раз \n ");
// }

// double Distance(int[]FirstPoint,int[] SecondPoint)
// {
//     double distance= 0;
//     distance = Math.Sqrt(Math.Pow((SecondPoint[0]-FirstPoint[0]),2)+Math.Pow((SecondPoint[1]-FirstPoint[1]),2)+Math.Pow((SecondPoint[2]-FirstPoint[2]),2));
//     return distance;
// }
// Console.Write("\nРасчитаем расстояние между точками\n");
// int[] FirstPoint = new int[3];
// int[] SecondPoint = new int[3];
// Console.Write("\nВведите координаты первой точки:\n");
// for (int i = 0; i < FirstPoint.Length; i++)
// {
//     FirstPoint[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.Write("\nВведите координаты второй точки:\n");
// for (int i = 0; i < SecondPoint.Length; i++)
// {
//     SecondPoint[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.Write($"Расстояние между точками равно: {Distance(FirstPoint,SecondPoint)}");


int CubesTable(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(" куб числа {0} = {1}\n", i, Math.Pow(i, 3));
    }

    return number;
}
Console.WriteLine("Введите число для таблицы кубов");
int number = Convert.ToInt32(Console.ReadLine());
CubesTable(number);