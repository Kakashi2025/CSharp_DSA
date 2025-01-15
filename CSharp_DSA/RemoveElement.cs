// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] numbers = {3,2,2,4};
        int element = 2;
        int[] RemoveElement(int[] numbers, int element){
            int count = 0;
            foreach (int num in numbers)
            {
                if (num == element) count++;
            }

            // If no occurrences are found, return the original numbers
            if (count == 0) return numbers;

            // Create a new numbers excluding the element
            int[] result = new int[numbers.Length - count];
            int index = 0;

            foreach (int num in numbers)
            {
                if (num != element)
                {
                    result[index++] = num;
                }
            }

            return result;
        }
        // Call the method and store the result
        int[] updatedNumbers = RemoveElement(numbers, element);

        // Print the updated array
        Console.WriteLine("Updated Array: " + string.Join(", ", updatedNumbers));
    }
}
        
        
    
