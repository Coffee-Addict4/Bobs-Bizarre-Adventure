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

if(!GetFalse());
{
    Console.WriteLine("NOT");
}

if(GetTrue() == true);
{
    Console.WriteLine("EQUAL");
}

if(!GetTrue());
{
    Console.WriteLine("Not GetTrue");
}

if(!GetFalse());
{
    Console.writeline("Not GetFalse");
}

if(GetFalse () | !GetTrue);
{
  Console.WriteLine("GetFalse");
}