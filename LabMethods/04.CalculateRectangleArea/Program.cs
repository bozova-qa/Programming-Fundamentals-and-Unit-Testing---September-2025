int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
Console.WriteLine(GetReactangleArea(length, width));//взима върнатия резултат от метода и го принтира

//метод, който изчислява и връща лице на правоъгълник
static int GetReactangleArea (int length, int width)
{
    int area = width * length;
    return area;
}
