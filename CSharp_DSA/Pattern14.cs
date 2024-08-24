// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n =4;
        for(int i=0;i<n;i++){
            for(char ch = 'A'; ch<='A'+i;ch++){
              Console.Write(ch + " ");
              
          }
            Console.WriteLine("");
        }
    }
}

// Output for n = 4;

// A 
// A B 
// A B C 
// A B C D 
