static void GradeInWords (double gradeParameter)// grade е параметър, който живее в кода отдолу
{
    if (gradeParameter >= 2.00 && gradeParameter <= 2.99)
    {
        Console.WriteLine("Fail");
    }
    else if (gradeParameter >= 3.00 && gradeParameter <= 3.49)
    {
        Console.WriteLine("Average");
    }
    else if (gradeParameter >= 3.50 && gradeParameter <= 4.49)
    {
        Console.WriteLine("Good");
    }
    else if (gradeParameter >= 4.50 && gradeParameter <= 5.49)
    {
        Console.WriteLine("Very good");
    }
    else if (gradeParameter >= 5.50 && gradeParameter <= 6.00)
    {
        Console.WriteLine("Excellent");
    }
}
double gradeFromUser = double.Parse(Console.ReadLine()); // това е променлива, взима се от user и се подава на метода
GradeInWords(gradeFromUser);

