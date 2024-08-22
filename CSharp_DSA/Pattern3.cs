using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = 6;
        for(int i =1; i<=n; i++){
            for(int j = 1; j<=i; j++){
                Console.Write(j + " ");
            }
            Console.WriteLine("");
        }
        }
    }
