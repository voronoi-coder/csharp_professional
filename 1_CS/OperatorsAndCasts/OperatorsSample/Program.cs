try
{
    OverflowExceptionSample();
}
catch (OverflowException e)
{
    Console.WriteLine(e.Message);
}
IsOperator();
AsOperator();

SizeOfSample();

Console.WriteLine(typeof(string));
Console.WriteLine(typeof(int));

int? a = null;
int b;
b = a ?? 10;
a = 3;
b = a ?? 10;

int[]? arr = null;

int x = arr?[0] ?? 0;
Console.WriteLine(x);


void OverflowExceptionSample()
{
    Console.WriteLine(nameof(OverflowException));
    byte b = byte.MaxValue;
    checked
    {
        b++;
    }
    Console.WriteLine(b);
    Console.WriteLine();
}

void IsOperator()
{
    Console.WriteLine(nameof(IsOperator));
    int i = 10;
#pragma warning disable CS0183 // 'is' expression's given expression is always of the provided type
    if (i is object)
#pragma warning restore CS0183 // 'is' expression's given expression is always of the provided type
    {
        Console.WriteLine("i is an object");
    }
    Console.WriteLine();
}

void AsOperator()
{
    object o1 = "Some String";
    object o2 = 5;
    string? s1 = o1 as string;
    string? s2 = o2 as string;
    Console.WriteLine($"o1 as string assigns a string to s1: {s1}");
    Console.WriteLine($"o2 as string assigns null to s2 because o2 is not a string: {s2}");
    Console.WriteLine();
}

void SizeOfSample()
{
    Console.WriteLine(nameof(SizeOfSample));
    Console.WriteLine(sizeof(int));

    unsafe
    {
        Console.WriteLine(sizeof(Point));
    }

    Console.WriteLine();
}