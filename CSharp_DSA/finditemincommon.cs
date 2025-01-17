using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr1 = {1,2,3,4,6,6,4,4,3};
        int[] arr2 = {192,213,48,39,20,38,21,0};

        bool itemInCommon(int[] arr1, int[] arr2)
        {
            for(int i=0; i<arr1.Length; i++){
                for(int j=0; j<arr2.Length; j++){
                    if(arr1[i] == arr2[j]){
                        return true;
                        break;
                    }
                }
            }

            // Convert the duplicates to an array and return
            return false;
        }

        Console.WriteLine(itemInCommon(arr1,arr2));
    }
}
