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