#r "../../../source/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.NetStandard10/bin/Release/netstandard1.0/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.dll"
#load "./Data.csx"


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
Console.WriteLine($"List<int>.MeanArithmetic()");
Console.WriteLine($"          mean_arithmetic    = {average}");
Console.WriteLine($"          size               = {data01.Count}");
Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
sw.Reset();
//----------------------------------------------------------------------------------------------------
