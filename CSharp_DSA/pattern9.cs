// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public void erect_pyramid(int N)
    {
        for (int i = 0; i < N; i++)
    {
        // For printing the spaces before stars in each row
        for (int j =0; j<N-i-1; j++)
        {
            Console.Write(" ");
        }
       
        // For printing the stars in each row
        for(int j=0;j< 2*i+1;j++){
            
            Console.Write("*");
        }
        
        // For printing the spaces after the stars in each row
         for (int j =0; j<N-i-1; j++)
        {
            Console.Write(" ");
        }
        
        // As soon as the stars for each iteration are printed, we move to the
        // next row and give a line break otherwise all stars
        // would get printed in 1 line.
        Console.WriteLine("");
    }
}

public void inverted_pyramid(int N)
{
    // This is the outer loop which will loop for the rows.
    for (int i = 0; i < N; i++)
    {
        // For printing the spaces before stars in each row
        for (int j =0; j<i; j++)
        {
            Console.Write(" ");
        }
       
        // For printing the stars in each row
        for(int j=0;j< 2*N -(2*i +1);j++){
            
            Console.Write("*");
        }
        
        // For printing the spaces after the stars in each row
         for (int j =0; j<i; j++)
        {
            Console.Write(" ");
        }
        
        // As soon as the stars for each iteration are printed, we move to the
        // next row and give a line break otherwise all stars
        // would get printed in 1 line.
        Console.WriteLine("");
    }
    }
    public static void Main(string[] args){
        int N = 6;
        HelloWorld hw = new HelloWorld();
        hw.erect_pyramid(N);
        hw.inverted_pyramid(N);
    }
}
