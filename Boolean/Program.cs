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

bool Test()
{
    Console.WriteLine("Test is true");
    return Test; // 2
}

bool NagativeTest();
{
    Console.WriteLine(Test is nagative);
    return Test; //3
}

if(!Test() && GetTrue);
{
    Console.WriteLine("GetFalse");
}

