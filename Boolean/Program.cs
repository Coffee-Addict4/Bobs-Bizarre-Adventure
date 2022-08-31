// See https://aka.ms/new-console-template for more information

bool GetFalse()
{
    Console.WriteLine("Getting false");

    return false; // 0
}

bool GetTrue()
{
    Console.WriteLine("Getting true");
    return true; // 1
}

if(GetTrue() || GetFalse())
{
    Console.WriteLine("XOR");
}

if(GetTrue() | GetFalse())
{
    Console.WriteLine("OR");
}

if(GetTrue() && GetFalse())
{
    Console.WriteLine("AND");
}

if(!GetFalse())
{
    Console.WriteLine("NOT");
}

if(GetTrue() == true)
{
    Console.WriteLine("EQUAL");
}

if(!GetTrue())
{
    Console.WriteLine("Not GetTrue");
}

if(!GetFalse())
{
    Console.WriteLine("Not GetFalse");
}

if(GetFalse())
{
    // if it was true logic go here
    Console.WriteLine("GetFalse=True");
}
else if(GetTrue())
{
    // if false logic go
  Console.WriteLine("GetFalse=False");
}

if(GetTrue() == true)
{
    Console.WriteLine("GetTrue is True");
}
else
{
    Console.WriteLine("GetTrue is False");
}

if(GetTrue() == false)
{
    Console.WriteLine("GetTrue = False");
}
else if (GetTrue() == true)
{
    Console.WriteLine("GetTrue = True");
}

int sum1 = 100 + 50;
int sum2 = sum1 + 250;
int sum3 = sum2 + sum2;

if(sum2 >= 400)
{
    Console.WriteLine("Sum2 >= 400");
}
else
{
    Console.WriteLine("False");
}

int X = 100;
int Y = 200;
int Z  = Y + X;

if(Y > X)
{
Console.WriteLine("Y > X");
}
else
{
    Console.WriteLine("Y isn't Greater then X?");
}

if(X < Y && Y < Z == true)
{
    Console.WriteLine("X < Y < Z");
}
else if (X > Y | Y > Z == false)
{
    Console.WriteLine("Bad math");
}

IEnumerable<int> GetNumbers(int howManyNumbers)
{
    for(int i=0; i<howManyNumbers; i++)
    {
        yield return i;
    }
}
List<int> numbers; // Declare
numbers = GetNumbers(200).ToList(); // Set variable

// Get all the even numbers from this list and print them to console

foreach (var number in numbers)
{
    if(number%2==0)
    Console.WriteLine(number);
}

foreach (var number in numbers)
{
    Console.WriteLine($"number:{number} remainder:{number%9}");
}

foreach (var number in numbers)
{
    Console.WriteLine($"number:{number} multible:{number*2}");
}

foreach (var number in numbers)
{
    Console.WriteLine($"number{number} division:{number/2}");
}

foreach (var number in numbers)
{
    Console.WriteLine($"number{number} Multible:{number*2} Division{number/2} remainder {number%2}");
}

foreach (var number in numbers)
{
    Console.WriteLine($"number:{number} Added to self:{number+number}");
}

foreach (var number in numbers)
{
    Console.WriteLine($"number{number} Number multilied by self multiplied by self:{number*number*number}");
}

foreach (var number in numbers)
{
    if(number%2==0==false)
    Console.WriteLine($"number:{number} Really big number{number*number*number*number/number}");
}