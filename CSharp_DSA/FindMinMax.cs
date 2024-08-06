// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] myArray = {7,23,14,5,10,102};
           int min = myArray[0];
           int max = myArray[0];
           for(int i =1; i<myArray.Length; i++){
               if(myArray[i] > max){
                   max = myArray[i];
                   
               }else if(myArray[i] < min){
                   min = myArray[i];
                   
               }
           
           
       }
       Console.WriteLine(min);
       Console.WriteLine(max);
    }
}
