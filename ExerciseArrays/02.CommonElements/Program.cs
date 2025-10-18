int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


//използваме вложен цикъл, защото вътрешният цикъл се завърта изцяло, докато външният направи само една итерация
for (int position = 0; position < firstArray.Length; position++)
{
    int currentNumberFirstArray = firstArray[position];
    
    for (int positionSecond = 0; positionSecond < secondArray.Length; positionSecond++)
  
    {
        int currentNumberSecondArray = secondArray[positionSecond];
        if (currentNumberFirstArray == currentNumberSecondArray)
        {
            Console.Write(currentNumberFirstArray + " ");
        }
    }
}

// foreach(var item in fristArray) 
//{
//    if (secondArray.Contains(item))
//    {
//        Console.Write(currentElement + " ");
//    }
//}
