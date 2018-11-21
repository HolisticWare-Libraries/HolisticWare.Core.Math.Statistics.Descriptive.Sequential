LoadAssembly("../../source/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.NetStandard10/bin/Release/netstandard1.0/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.dll")
// Stopwatch
using System.Diagnostics;

// namespace inclusion (using) necessary for LINQ Extension methods
using Core.Math.Statistics.Descriptive.Sequential;

//ShowUsing (); 

//----------------------------------------------------------------------------------------------------
List<int> data01 = new List<int>()
{
    1,
    2,
    4,
    5
};

Stopwatch sw = null;

//----------------------------------------------------------------------------------------------------
sw = Stopwatch.StartNew();
double average = data01.Average();
sw.Stop();
Console.WriteLine($"List<int>.MeanArithmetic()");
Console.WriteLine($"          mean_arithmetic    = {average}");
Console.WriteLine($"          size               = {data01.Count}");
Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
sw.Reset();
//----------------------------------------------------------------------------------------------------
