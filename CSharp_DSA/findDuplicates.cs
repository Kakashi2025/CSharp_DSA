// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1,4,6,5,3,9,8,6,0,4,7};
        
        int[] findDuplicates(int[] arr){
            List<int> duplicates = new List<int>();
            
            for(int i=0; i<arr.Length; i++){
                for(int j= i+1; j<arr.Length; j++){
                    if(arr[i] == arr[j] ){
                        duplicates.Add(arr[i]);
                        
                    }
                }
                
            }
            return duplicates.ToArray();
        }
        int[] result = findDuplicates(arr);
        Console.WriteLine(string.Join(", ", result));
    }
}
