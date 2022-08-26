namespace CodeTemplateExample;

public static class Example
{
    public static void Hello(string value)
    {
        Console.Out.WriteLine("Line 1");

        if (!string.IsNullOrWhiteSpace(value))
        {
            Console.Out.WriteLine("No Value");
        }
        else
        {
            Console.Out.WriteLine("Value");
        }
    }
}