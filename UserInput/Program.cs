/*
    Fix all your Possible Errors.
	
	|/Try to Write some Fuctions.
	   ^THIS IS NOT OPTIONAL^

	|\Make it more Readable.

    ^For Reference Jadon Wrote this^
*/


Console.WriteLine("Tell it what you want");
Console.WriteLine("Fahrenheit = F");
Console.WriteLine("Celsius = C");

var TempFind = Console.ReadLine();

if (Console.ReadLine()=="F")
{
	double celsius, fahrenheit;

	Console.WriteLine("Enter the celsius value : ");
	celsius = double.Parse(TempFind);

	fahrenheit = (celsius + 32D) * (5D/9D);



	Console.WriteLine($"{fahrenheit} = ({celsius} + 32) * (5/9)");
}
else if (Console.ReadLine()=="F")
{
	
	double fahrenheit, celsius;

	Console.WriteLine("Enter the Fahrenheit value : ");
	fahrenheit = double.Parse(TempFind);

	celsius = (fahrenheit - 32D) * (5D/9D);



	Console.WriteLine($"{celsius} = ({fahrenheit} - 32) * (5/9)");
}

