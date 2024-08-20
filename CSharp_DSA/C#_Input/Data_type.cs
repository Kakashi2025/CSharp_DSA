using System;

public class Program
{
    public static int DataTypeSize(string dataType)
    {
        // Dictionary to map data types to their sizes in bytes
        switch (dataType.ToLower())
        {
            case "int":
                return sizeof(int);
            case "char":
                return sizeof(char);
            case "float":
                return sizeof(float);
            case "double":
                return sizeof(double);
            case "long":
                return sizeof(long);
            case "short":
                return sizeof(short);
            case "bool":
                return sizeof(bool);
            case "byte":
                return sizeof(byte);
            default:
                return -1; // Return -1 for invalid data types
        }
    }

    public static void Main()
    {
        // Example usage
        Console.WriteLine(DataTypeSize("int"));    // Output: 4
        Console.WriteLine(DataTypeSize("char"));   // Output: 2
        Console.WriteLine(DataTypeSize("double")); // Output: 8
        Console.WriteLine(DataTypeSize("unknown"));// Output: -1
    }
}
