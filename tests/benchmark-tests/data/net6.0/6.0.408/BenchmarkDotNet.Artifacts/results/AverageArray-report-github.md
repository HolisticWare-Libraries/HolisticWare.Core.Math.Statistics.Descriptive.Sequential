``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.408
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
|                       Method |      Mean |     Error |    StdDev |    Median |
|----------------------------- |----------:|----------:|----------:|----------:|
|                      Foreach |  2.943 ns | 0.0872 ns | 0.1278 ns |  2.889 ns |
|      For_Length_Recalculated |  3.447 ns | 0.0971 ns | 0.0861 ns |  3.432 ns |
| For_Length_PreCalculted_long |  4.926 ns | 0.1263 ns | 0.2927 ns |  4.817 ns |
|  For_Length_PreCalculted_int |  4.694 ns | 0.1200 ns | 0.1063 ns |  4.676 ns |
|           LINQ_Method_Syntax | 37.088 ns | 0.5911 ns | 0.7037 ns | 36.884 ns |
|            LINQ_Query_Syntax | 69.952 ns | 1.1997 ns | 1.0018 ns | 69.567 ns |
