// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
        
    public static void Main(string[] args){
        int n = 6;
        for(int i =1; i<=2*n-1; i++){
        int stars =i;
        if(i>n) stars = 2*n-i;
        for(int j=1;j<=stars;j++){
              Console.Write("*");
        }

        Console.WriteLine("");
    }
}
}
