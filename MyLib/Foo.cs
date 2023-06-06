namespace MyLib;

public static class Foo
{
    public static string FizzBuzz(int i) => i switch
    {
        int when i % 3 == 0 && i % 5 == 0 => "fizzbuzz",
        int when i % 3 == 0 => "fizz",
        int when i % 5 == 0 => "buzz",
        _ => i.ToString()
    };
}
