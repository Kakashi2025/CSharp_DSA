// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] numbers = {0,-1,2,-3,1};
        bool findzerotriplets(int[] numbers){
            int n = numbers.Length;
            bool res = false;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if(numbers[i] + numbers[j] + numbers[k] == 0)
                           return true;
                        
                    }
                    
                    }
                }
                return false;
            }
            Console.WriteLine(findzerotriplets(numbers));
        }
        
    }
