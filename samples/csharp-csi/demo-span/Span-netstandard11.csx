#r "../../../source/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.NetStandard11/bin/Release/netstandard1.1/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.dll"
#r "../../..//tests/unit-tests/project-references/packages/System.Memory.4.5.1/ref/netstandard1.1/System.Memory.dll"
#load "./Data.Array.csx"


// Stopwatch
using System.Diagnostics;

// namespace inclusion (using) necessary for LINQ Extension methods
using Core.Math.Statistics.Descriptive.Sequential;

//ShowUsing (); 

Stopwatch sw = null;

//----------------------------------------------------------------------------------------------------
sw = Stopwatch.StartNew();
double average = data01.Average();
sw.Stop();
Console.WriteLine($"List<int>.Average()");
Console.WriteLine($"          average            = {average}");
Console.WriteLine($"          size               = {data01.Length}");
Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
sw.Reset();
//----------------------------------------------------------------------------------------------------
sw = Stopwatch.StartNew();
double average1 = data01.Average();
sw.Stop();
Console.WriteLine($"List<int>.Average()");
Console.WriteLine($"          average            = {average}");
Console.WriteLine($"          size               = {data01.Length}");
Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
sw.Reset();
//----------------------------------------------------------------------------------------------------
void f()
{
    Span<int> data01_span = data01.AsSpan<int>();
    sw = Stopwatch.StartNew();
    double mean_arithmetic = data01_span.MeanArithmetic();
    sw.Stop();
    Console.WriteLine($"List<int>.MeanArithmetic()");
    Console.WriteLine($"          mean_arithmetic    = {mean_arithmetic}");
    Console.WriteLine($"          size               = {data01.Length}");
    Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
    Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
    sw.Reset();
}
f();
//----------------------------------------------------------------------------------------------------
