using System;
public class ArrayExample
{
    static void printArray(int[] arr)
    {
        Console.WriteLine("Printing array elements:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    public static void Main(string[] args)
    {
        int[] arr1 = { 25, 10, 20, 15, 40, 50 };
        
        printArray(arr1);//passing array to function  
        
    }
}