public static class Conversor
{
    public static decimal CelsiusParaFahrenheit(decimal celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static decimal FahrenheitParaCelsius(decimal fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}