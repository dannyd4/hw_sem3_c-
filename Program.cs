// test 19 sem3 c#
/*
void palindrom(int arg)
{
     int d1 = arg % 10;
     int d2 = (arg/10) % 10;
     int d3 = (arg/100) % 10;
     int d4 = (arg/1000) % 10;
     int d5 = (arg/10000) % 10;

     if (d1==d5 && d2==d4)
     {
        Console.WriteLine(arg + " - это палиндром!");
     }
     else Console.WriteLine(arg + " - это НЕ палиндром!");
}

Console.WriteLine("Ведите число от 10000 до 99999");
int x = Convert.ToInt32(Console.ReadLine());// ввод числа

if(10000 <= x && x <= 99999) // проверка на попадание в диапазон
{
palindrom(x);//метед (функция)
}
else Console.WriteLine("Число вне диапазона от 10000 до 99999"); //если вне диапазона
*/

// test 21 sem3 c#
/*
void length (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double d = Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1))+((z2-z1)*(z2-z1)));

    Console.WriteLine(d + " - это длина отрезка в 3D пространстве!");
}

Console.WriteLine("Введите координаты точки А (x,y,z):");
Console.Write("  x= ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("  y= ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("  z= ");
double c = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки B (x1,y1,z1):");
Console.Write("  x1= ");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("  y1= ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("  z1= ");
double c1 = Convert.ToDouble(Console.ReadLine());

length(a,a1,b,b1,c,c1);
*/

// test 23 sem3 c#
/*
void cube (int x)
{
    for(int i = 0; i <= x; i++) Console.Write((i*i*i) + "  "); 
}

Console.Write("Введите целое положительное число N = ");
int x = Convert.ToInt32(Console.ReadLine());

if ( x < 0 )
{
    Console.Write("Введено отрицательное число N = " + x);
}
    else cube(x);
    */


