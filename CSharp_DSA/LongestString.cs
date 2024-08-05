// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] fruit = {"banana", "apple", "pineapple", "Dragonfruit"};
        string findLargest(string[] fruit){
            
            string longestfruit ="";
            for(int i=0; i<fruit.Length; i++){
                string currentfruit = fruit[i];
                if(currentfruit.Length > longestfruit.Length){
                    
                    longestfruit = currentfruit;
                }
                
            }
            return longestfruit;
        }
        Console.WriteLine(findLargest(fruit));
    }
}