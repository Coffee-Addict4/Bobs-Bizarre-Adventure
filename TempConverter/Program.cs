using System; 

double GetUserTempature()
{
    var userInput = Console.ReadLine();

    if(double.TryParse(userInput, out double temp))
    {
        return temp;
    }

    throw new ArgumentException("User did not enter a valid number", "UserInput");
}

double ConvertTempature(TempConversion tempConversion, double fromTemp)
{
    switch(tempConversion)
    {
        case TempConversion.CelsiusToFahrenheit:
            return (fromTemp + 32D) * (5D/9D);
        case TempConversion.FahrenheitToCelsius:
            return(fromTemp - 32D) * (5D/9D);
    }

    throw new ArgumentException("Do not support temp conversion", nameof(tempConversion));
}


double someTemp = 400;

var celsius = ConvertTempature(TempConversion.FahrenheitToCelsius, someTemp);

var fahrenheit = ConvertTempature(TempConversion.CelsiusToFahrenheit, celsius);

if(fahrenheit != someTemp)
{
    throw new InvalidOperationException("Temp conversion is wrong");
}
else
{
    Console.WriteLine("Temp conversion is working");
}

Console.WriteLine("Tell it what you want");
Console.WriteLine("Fahrenheit = F");
Console.WriteLine("Celsius = C");

string userInput = Console.ReadLine();

switch(userInput)
{
    case "F":
    case "f":
        Console.WriteLine("enter temp: ");
        double userTemp = GetUserTempature();
        double c = ConvertTempature(TempConversion.FahrenheitToCelsius, userTemp);
        Console.WriteLine($"{userTemp} = ({c} + 32) * (5/9)");        
        return;
    case "c":
    case "C":
        Console.WriteLine("enter temp: ");
        double userTemp = GetUserTempature();
        double f = ConvertTempature(TempConversion.CelsiusToFahrenheit, userTemp);
    	Console.WriteLine($"{f} = ({userTemp} - 32) * (5/9)");
        return;
}


public enum TempConversion
{
    CelsiusToFahrenheit,
    
    FahrenheitToCelsius
}