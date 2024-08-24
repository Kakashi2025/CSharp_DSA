// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n =4;
        
        for(int i=0;i<n;i++){
            char ch = (char)('A'+ i);
            for(int j=0; j<=i;j++){
              Console.Write(ch + " ");
              
          }
            Console.WriteLine("");
        }
    }
}

// Output for n =4;
// A 
// B B 
// C C C 
// D D D D 
