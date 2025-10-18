int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

for (int position = 0; position <= firstArray.Length - 1; position++)
{
    if (firstArray[position] == secondArray[position])
    {
        if (position == firstArray.Length - 1)
        {
            Console.WriteLine("Arrays are identical.");
            break;
        }
        continue;
    }
    else
    {
        Console.WriteLine("Arrays are not identical.");
        break;
    }
}

//Another way:
//isIdentical = True;

//for (int i = 0; i < firstArray.Length; i++) 
//{
//    int currentElementFirstArray = firstArray[i];
//    int currentElementSecondArray = secondArray[i];
//      if (currentElementFirstArray != currentElementSecondArray)
//        {
//    isIdentical = false;
//    break;
//        }

//}

//if (isIdentical)
//{
//    Console.WriteLine("Arrays are identical.");
//}
//else
//{
//    Console.WriteLine("Arrays are not identical.");
//}
