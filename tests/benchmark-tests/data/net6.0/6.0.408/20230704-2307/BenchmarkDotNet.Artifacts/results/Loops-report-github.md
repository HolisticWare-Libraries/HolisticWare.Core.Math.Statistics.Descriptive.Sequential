``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-preview.4.23260.5
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
|                                                    Method |       Mean |     Error |    StdDev |     Median |
|---------------------------------------------------------- |-----------:|----------:|----------:|-----------:|
|                          Foreach_Over_Array_Sum_As_Double |   5.999 ns | 0.1510 ns | 0.3284 ns |   5.900 ns |
|          For_Over_Array_Sum_As_Double_Length_Recalculated |   6.372 ns | 0.1344 ns | 0.1122 ns |   6.342 ns |
|     For_Over_Array_Sum_As_Double_Length_PreCalculted_long |   8.238 ns | 0.1507 ns | 0.1336 ns |   8.219 ns |
|      For_Over_Array_Sum_As_Double_Length_PreCalculted_int |   8.194 ns | 0.0817 ns | 0.0682 ns |   8.200 ns |
|                             LINQ_Method_Syntax_Over_Array |  62.737 ns | 0.6022 ns | 0.5339 ns |  62.750 ns |
|                             LINQ_Query_Syntax_Over_Array_ | 113.470 ns | 2.3043 ns | 5.5650 ns | 111.560 ns |
|                      Foreach_Over_Span_With_Sum_As_Double |   6.142 ns | 0.1087 ns | 0.1017 ns |   6.121 ns |
|      For_Over_Span_With_Sum_As_Double_Length_Recalculated |   5.847 ns | 0.1463 ns | 0.1685 ns |   5.800 ns |
| For_Over_Span_With_Sum_As_Double_Length_PreCalculted_long |   6.426 ns | 0.1296 ns | 0.1149 ns |   6.426 ns |
|  For_Over_Span_With_Sum_As_Double_Length_PreCalculted_int |   6.211 ns | 0.1513 ns | 0.1801 ns |   6.207 ns |
