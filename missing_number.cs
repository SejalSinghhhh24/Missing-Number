using System;
 
class GFG {
    // Function to find missing number
    static int getMissingNo(int[] a, int n)
    {
        int total = (n + 1) * (n + 2) / 2;
        Console.Write("Array size");
        int s=Convert.ToInt32(Console.ReadLine());
        Console.Write("Input elements in array");
        
        for(int x=0;x<s;x++)
        {
            
            a[x]=Convert.ToInt32(Console.ReadLine());
        }
 
        for (int i = 0; i < n; i++)
            total -= a[i];
 
        return total;
    }
 
    /* program to test above function */
    public static void Main()
    {
        int[] a = { 1, 2, 4, 5, 6 };
        int miss = getMissingNo(a, 5);
        Console.Write("missing number:\n");
        Console.Write(miss);
    }
}