namespace Domain;

public static class Extensions
{
    public static string ToPrettyString(this decimal number) =>
        $"{number:#,##0.##}";
}
