 /*     |y
        |
  II    |      I (x > 0, y > 0)
        |
        |
__________________x
        |
        |
III     |       IV
        |
II(x<0, y>0)
III(x<0, y<0)
IV(x>0, y<0)

void Funkt(int x, int y)
{
    if (x > 0 && y > 0)
    Console.WriteLine("this point on 1st quater");
    else if (x < 0 && y > 0)
    Console.WriteLine("this point on 2st quater");
    else if (x < 0 && y < 0)
    Console.WriteLine("this point on 3st quater");
    else if (x < 0 && y < 0)
    Console.WriteLine("this point on 4st quater");
    else Console.WriteLine("its imposible at this task");
}
Console.WriteLine("input your x number: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input your y number: ");
int yCoord = Convert.ToInt32(Console.ReadLine());
Funkt(xCoord, yCoord);
*/

//Напишите программу, которая по заданному номеру четверти,
//показывает диапозон возможных координат точек в этой четверти(x и y)

/*void PossibleValue(int n)
{
    if(n == 1)
        Console.WriteLine("1st quater x>0, y>0");
    else if (n == 2)
        Console.WriteLine("2nd quater x<0, y>0");
    else if (n == 3)
        Console.WriteLine("3rd quater x<0, y<0");
    else Console.WriteLine("4th quater x>0, y<0");
}
Console.WriteLine("input number quater: ");
int numQuater = Convert.ToInt32(Console.ReadLine());
if(numQuater >=1 && numQuater <= 4)
PossibleValue(numQuater);
else Console.WriteLine("its not number of quater: ");
*/

//Программа, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 2D пространстве

//Math.Sqrt(num)

/*double LongLine(int x1, int y1, int x2, int y2)
{
    int x = x2 - x1;
    int y = y2 - y1;
    double lengthAB = Math.Round(Math.Sqrt(x*x + y*y),3);
    return lengthAB;
}
Console.WriteLine("input x coordinat of A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input x coordinat of A: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input x coordinat of B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input x coordinat of B: ");
int yB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xA, yA, xB, yB);
Console.WriteLine($"Distance AB is {dist}");
*/

//Программа, которая принимает на вход число (N) и
//выдает таблицу квадратов чисел от 1 до (N).

/*void Qurd(int num)
{
    int current = 1;
    while(current <= num)
    {
        int res = current * current;
        Console.Write($"{res}, ");
        current ++;
    }
    Console.WriteLine($"\b\b.");
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{
    Console.Write($"{number} -> ");
    Qurd(number);
}
else Console.WriteLine("imposible number!");
*/

//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет, 12821 -> да, 23432 -> да

/*void Polindrome(int num)
{
    int current = num / 1000;
    if(current / 100 == 0)
    {
        if ((num / 10000) == (num % 10) && (current % 10) == (num % 100) / 10)
        {
            Console.WriteLine($"Number {num} is polindrome");
        }
        else Console.WriteLine($"Number {num} is not polindrome");  
    } else Console.WriteLine($"Number {num} have not five numbers"); 
}

Console.WriteLine("Input 5 numbers: ");
int number = Convert.ToInt32(Console.ReadLine());
Polindrome(number);
*/

//Задача 21; Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84, A (7,-5, 0); B (1,-1,9) -> 11.53

/*double LongLine(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int x = x2 - x1;
    int y = y2 - y1;
    int z = z2 - z1;
    double lengthAB = Math.Round(Math.Sqrt(x*x + y*y + z*z),2);
    return lengthAB;
}
Console.WriteLine("input x coordinat of A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input x coordinat of A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input x coordinat of A: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input x coordinat of B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input x coordinat of B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input x coordinat of B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Distance ABZ is {dist}");
*/

//Задача 23: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*void Qurd(int num)
{
    int current = 1;
    while(current <= num)
    {
        int res = current*current*current;
        Console.Write($"{res}, ");
        current ++;
    }
    Console.WriteLine($"\b\b.");
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{
    Console.Write($"{number} -> ");
    Qurd(number);
}
else Console.WriteLine("imposible number!");
*/
