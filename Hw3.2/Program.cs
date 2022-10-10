class Program
{ public static void Main()
{ double [] x = new double [6];
double d, distance = 0.0;
Console.WriteLine("Введите кординаты двух точек через пробел");
Console.WriteLine("x1 y1 z1 x2 y2 z2:");
var line = Console.ReadLine().Split();
for (int i = 0; i < 3; i++)
{ d = Convert.ToDouble(line[i + 3])
- Convert.ToDouble(line[i]);
distance += d * d; }
Console.WriteLine("Расстояние между двумя точками = " + Math.Sqrt(distance)); } } 