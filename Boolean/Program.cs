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

if(GetTrue() && GetFalse());
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
else if(!GetTrue())
{
    // if false logic go
  Console.WriteLine("GetFalse=False");
}

if(GetTrue() == true)
{
    Console.ForegroundColor(ConsoleColor.Red);
    Console.WriteLine("GetTrue is True");
}
else
{
    Console.WriteLine("GetTrue is False");
}