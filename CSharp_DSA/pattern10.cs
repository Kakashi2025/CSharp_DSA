// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = 6;
        int start = 1;
        
        for(int i=0; i<n;i++){
            if(i % 2 == 0){
              start = 1;  
            } else{
                start = 0;
            }
            
            for(int j=0;j<=i;j++){
              Console.Write(start + " ");
              start = 1-start;
          }
          Console.WriteLine("");
        }
        
        
    }
}

// Output for n = 6

// 1 
// 0 1 
// 1 0 1 
// 0 1 0 1 
// 1 0 1 0 1 
// 0 1 0 1 0 1 
