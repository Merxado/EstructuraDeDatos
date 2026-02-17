namespace CodesShare;

public static class Extensions
{
    public static int GetInt(string message)
    {
        Console.Write(message);
        var numberString = Console.ReadLine();
        if (int.TryParse(numberString, out int numberInt))
        {
            return numberInt;
        }

        return 0;
    }

    public static string? GetString(string message, List<string> options)
    {
        Console.Write(message);
        var answer = Console.ReadLine();
        var input = Console.ReadLine();
        if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))
        {
            return answer;
        }
        return null;
    }
}
