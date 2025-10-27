using System;

namespace TestApp;

//class - блок от код, в който можем да имаме методи
public class Reverse
{
    //public method - можем да го използваме навсякъде в solution-a
    //static method - можем да го извикаме чрез името на класа
    public static string ReverseArray(int[] arr)
        //int[] arr = [2, 3, 4, 5 ]
    {
        Array.Reverse(arr);
        //[5, 4, 3, 2]
        return string.Join(" ", arr); //"5 4 3 2"
    }
}
