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
using System.Drawing;

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



//ESERCIZIO
//int[] baseArr = new[] { 2, 6, 7, 5, 3, 9 };
//1
//Console.WriteLine("uso la prima funzione");
//stampaArray(baseArr);
//2
//Console.WriteLine("uso la seconda e la prima funzione");
//int[] newArr = QuadArray(baseArr);
//stampaArray(newArr);
//3
//Console.WriteLine("uso la terza funzione");
//Console.WriteLine(sumElmArray(baseArr));
//4
//Console.WriteLine("uso le funzioni insieme");
//int[] newArr2= QuadArray(baseArr);
//Console.WriteLine(sumElmArray(newArr2));



//BONUS




int[] makeArray(int lenght)
{
    int[] newArray = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        Console.WriteLine("Inserisci un numero: ");
        int arrLenght = Convert.ToInt32(Console.ReadLine());
        newArray[i] = arrLenght;
        
    }

    return newArray;
}
Console.Write("Quanti numeri vuoi inserire: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] userArray = makeArray(lenght);
Console.WriteLine("Stampo l'array");
//1
stampaArray(userArray);
//2
Console.WriteLine("uso la seconda e la prima funzione");
int[] newArr = QuadArray(userArray);
stampaArray(newArr);
//3
Console.WriteLine("uso la terza funzione");
Console.WriteLine(sumElmArray(userArray));
//4
Console.WriteLine("uso le funzioni insieme");
int[] newArr2 = QuadArray(userArray);
Console.WriteLine(sumElmArray(newArr2));







