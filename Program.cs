//using System;
//public class ArrayExample
//{
//   static void printArray(int[] arr)
//   {
//       Console.WriteLine("Printing array elements:");
//       for (int i = 0; i < arr.Length; i++)
//       {
//           Console.WriteLine(arr[i]);
//       }
//   }
//   public static void Main(string[] args)
//   {
//       int[] arr1 = { 25, 10, 20, 15, 40, 50 };

//       printArray(arr1);//passing array to function  

//   }
//}



//public class Program
//{
//    public static void Quandrato()
//    {
//        double Result, Number1;

//        Number1 = 3;


//        Result = Math.Pow(Number1, 2);
//        Console.WriteLine(Result);
//    }
//}

//1
void stampaArray(int[] array)
{
    foreach (int elem in array)
    {
        Console.Write($"{elem} ");
    }
}

//2
int Quad(int num)
{
    return num * num;
}

//3
int[] QuadArray(int[] array)
{
    int[] NewArray = new int[array.Length];

    for (int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i] = Quad(array[i]);
    }

    return NewArray;
}

//4
int sumElmArray(int[] array)
{
    int sum = 0;
    foreach (int elem in array)
    {
        sum += elem;
    }

    return sum;
}