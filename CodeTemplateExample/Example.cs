namespace CodeTemplateExample;

public static class Example
{
    public static void Hello(string value)
    {
        Console.Out.WriteLine("Line 1");

        // This way the hint is not displayed.
        // But if you now call value.HasText() once, the hint is displayed. 
        // If you delete value.HasText again and restart Rider, the hint is missing again.

        if (!string.IsNullOrWhiteSpace(value))
        {
            Console.Out.WriteLine("Value");
        }
        else
        {
            Console.Out.WriteLine("No Value");
        }
    }
}