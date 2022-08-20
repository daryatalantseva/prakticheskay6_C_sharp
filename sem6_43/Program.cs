/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
double  x,y;
Console.WriteLine("Ввежите коэффициенты b и k для первой прямой");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввежите коэффициенты b и k для второй прямой");
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

if ((k1 == k2) && (b1 == b2))
{
Console.WriteLine("Прямые совпадают");
}
else if (k1==k2)
{
Console.WriteLine("Прямые параллельны");
}
else

{

x=(b2-b1)/(k1-k2);

y=(k1*(b2-b1))/(k1-k2)+b1;

Console.WriteLine("Координаты точки пересечения x=" +Math.Round(x, 3) + " y=" + Math.Round(y, 3));

}

