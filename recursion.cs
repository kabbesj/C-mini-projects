using System;

class recursion
{
    static void recursionMethod(int remaining)
    {
        // This method could be optimized with tail recursion.
        if (remaining <= 0)
        {
            return;
        }
		//System.out.println(remaining);
		Console.WriteLine(remaining);
        recursionMethod(remaining - 1);
    }

    static void Main()
    {
        // Attempt to call this method.
        recursionMethod(100);
    }
}