// NOTE '\' instead of '/'
// scriptcs dislikes /* */ comments before #r directives
#r "../../../source/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.NetStandard10/bin/Debug/netstandard1.0/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.dll"

/*
It is posobile reference other (loose) assemblies from  CSX script by using a #r directive. 
In order for the assembly to be allowed to be used in the CSX file, it needs to be copied 
into the folder relative to the script path or be present in the GAC.
*/

using System;
using System.Linq;

// namespace inclusion (using) necessary for LINQ Extension methods
using Core.Math.Statistics.Descriptive.Sequential;

List<int> data01 = new List<int>(){1,2,4,5};

double mean_arithmetic_01 = data01.MeanArithmetic();
Console.WriteLine($"mean_arithmetic_01   = {mean_arithmetic_01}");  

double mean_geometric_01 = data01.MeanGeometric();
Console.WriteLine($"mean_geometric_01    = {mean_geometric_01}");  

double mean_geometric_02 = data01.MeanGeometricNaive();
Console.WriteLine($"mean_geometric_02    = {mean_geometric_02}");  

double mean_harmonic_01 = data01.MeanHarmonic();
Console.WriteLine($"mean_harmonic_01     = {mean_harmonic_01}");  

double mean_cubic_01 = data01.MeanCubic();
Console.WriteLine($"mean_cubic_01        = {mean_cubic_01}");  

double mean_quadratic_01 = data01.MeanQuadratic();
Console.WriteLine($"mean_quadratic_01    = {mean_quadratic_01}");  


