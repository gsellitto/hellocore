using System;

namespace hellocore
{
public class Class1 {
    public static void  test()
    {
        Console.WriteLine("Hello World! from class test");
        int pippo=0;
        Console.WriteLine($"Hello World! from class test {pippo}");
        pippo++;
        Console.WriteLine($"Hello World! from class test {pippo}");
    }
}
}