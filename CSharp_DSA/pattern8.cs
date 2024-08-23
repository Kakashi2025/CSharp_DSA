// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n =6;
        for(int i=0; i<n; i++){
            for(int j =0; j < i; j++){
                Console.Write(" ");
            }
            for(int j=0; j< 2 * n - (2 * i + 1); j++){
                Console.Write("*");
            }
            Console.WriteLine(" ");
        }
    }
}

// Output for n = 6

// *********** 
//  ********* 
//   ******* 
//    ***** 
//     *** 
//      * 
