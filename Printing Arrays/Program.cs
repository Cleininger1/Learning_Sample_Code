using System;

namespace Printing_Arrays
{
    class Printing_Arrays
    {
        static void Main(string[] args)
        {            
               // int[] anArray = { 34, 55, 67, 89, 99 };
               // foreach (var item in anArray)
              //  {
             //   Console.WriteLine(item.ToString();
            //    }
            int[] anArray = new int[5] {10, 15, 16, 8, 6 };
            //Array.ForEach(anArray, n => Console.WriteLine(n)); //---- Iterates Array
            
            Array.Sort(anArray);                                //----Sorts the array Ascending
           // Array.ForEach(anArray, n => Console.WriteLine(n));  //----Prints Sorted Array
            Array.Reverse(anArray);                               //--- Sorts Array descending
            Array.ForEach(anArray, n=> Console.WriteLine(n)); //----Prints Sorted Array in descending order

        }
    }
}
