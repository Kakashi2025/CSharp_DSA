// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = 4;
        int spaces = 2*(n-1);
        for(int i=1; i<= n; i++){
            for(int j =1; j<= i; j++){
                Console.Write(j);
            }
            
            for(int j = 1;j<=spaces;j++){
              Console.Write(" ");
          }
            
            for(int j = i; j>=1; j--){
                Console.Write(j);
            }
            
            Console.WriteLine("");
            
            spaces = spaces - 2;
        }
        
        
        
        
    }
}

// Output for n =4;
// 1      1
// 12    21
// 123  321
// 12344321
