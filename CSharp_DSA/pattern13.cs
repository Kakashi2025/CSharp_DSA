// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = 3;
        int num =1;
        for(int i=1; i<= n; i++){
            for(int j =1; j<= i; j++){
                Console.Write(num + " ");
                num += 1;
            }
            Console.WriteLine("");
           
        }    
    }
}

// output for n = 3;

// 1
// 2 3
// 4 5 6
