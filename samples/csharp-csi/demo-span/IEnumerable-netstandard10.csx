#r "../../../source/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.NetStandard10/bin/Release/netstandard1.0/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.dll"
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
sw = Stopwatch.StartNew();
double mean_arithmetic = data01.MeanArithmetic();
sw.Stop();
Console.WriteLine($"List<int>.MeanArithmetic()");
Console.WriteLine($"          mean_arithmetic    = {mean_arithmetic}");
Console.WriteLine($"          size               = {data01.Length}");
Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
sw.Reset();
//----------------------------------------------------------------------------------------------------
