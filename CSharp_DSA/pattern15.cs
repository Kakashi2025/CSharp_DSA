// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n =4;
        for(int i=0;i<n;i++){
            for(char ch = 'A'; ch<='A'+(n-i-1);ch++){
              Console.Write(ch + " ");
              
          }
            Console.WriteLine("");
        }
    }
}

// Output for n = 4;
// A B C D 
// A B C 
// A B 
// A 
