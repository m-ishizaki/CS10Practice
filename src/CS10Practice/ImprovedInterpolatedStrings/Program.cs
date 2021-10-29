A a = new();

a.Method($"{"Test"}");
a.Method($"a{1}b{2}c");
a.Method($"{DateTime.Now}");
/*
s
AppendLitera a
AppendFormatted System.Int32
AppendLitera b
AppendFormatted System.Int32
AppendLitera c
p
AppendFormatted System.DateTime
p
*/

class A
{
    public void Method(string s) { Console.WriteLine("s"); }
    public void Method(SampleHandler p) { Console.WriteLine("p"); }
}


[System.Runtime.CompilerServices.InterpolatedStringHandler]
public ref struct SampleHandler
{
    public SampleHandler(int literalLength, int formattedCount, out bool handlerIsValid) => handlerIsValid = true;
    public void AppendLiteral(string s) => Console.WriteLine($"AppendLitera {s}");
    public void AppendFormatted<T>(T t) => Console.WriteLine($"AppendFormatted {t.GetType().FullName}");
}
