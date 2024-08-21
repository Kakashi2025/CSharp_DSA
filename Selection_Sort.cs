// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {13,46,24,52,20,9};
        int n = arr.Length;
        
            for(int i=0; i< n; i++){
                for(int j = i+1; j<n; j++){
                    if(arr[i] > arr[j]){
                        int temp = arr[j];
                        arr[j]= arr[i];
                        arr[i] = temp;
                    }
                }
                Console.WriteLine(arr[i]);
            }
        }
        
        
    }
