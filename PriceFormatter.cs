using System.Globalization;

namespace BlazingPizza;

public static class PriceFormatter
{
    private static readonly CultureInfo MexicanCulture = CultureInfo.GetCultureInfo("es-MX");

    public static string Format(decimal amount)
    {
        return $"{amount.ToString("C", MexicanCulture)} MXN";
    }
}