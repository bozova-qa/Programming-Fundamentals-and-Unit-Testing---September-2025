//Tuple:
int x = 6;
int y = 7;

(int x, int y) point = (6, 7);

Console.WriteLine(point.x);
Console.WriteLine(point.y);

//Student

(string name, int age, string city, double grade) student = ("Ivan", 22, "Lovech", 5.50);
//това е т.нар. tuple -> всички други променливи се запазват в една променлива;

Console.WriteLine(student.name);//Ivan