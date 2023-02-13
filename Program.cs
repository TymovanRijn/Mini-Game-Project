/*
return value from a method
Write a program with a method called Pow2. This method takes an int as a parameter, and it returns the square. So for example: Pow2(5) should result in 25 as 5 * 5 is 25.

Note: your submission will be unit tested. In order for the unit test to be able to test your program, you should make your class public.
*/
public class Program
{
    public static void Main()
    {
        Console.WriteLine(Pow2(5));
        Console.WriteLine("hallo");
    }
    public static int Pow2(int number)
    {
        return number * number;
    }
}
