``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-preview.4.23260.5
  [Host]     : .NET 8.0.0 (8.0.23.25905), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.25905), X64 RyuJIT AVX2


```
|                                                    Method |      Mean |     Error |    StdDev |
|---------------------------------------------------------- |----------:|----------:|----------:|
|                          Foreach_Over_Array_Sum_As_Double |  5.117 ns | 0.0559 ns | 0.0467 ns |
|          For_Over_Array_Sum_As_Double_Length_Recalculated |  6.220 ns | 0.0798 ns | 0.0708 ns |
|     For_Over_Array_Sum_As_Double_Length_PreCalculted_long |  8.025 ns | 0.0947 ns | 0.0739 ns |
|      For_Over_Array_Sum_As_Double_Length_PreCalculted_int |  6.033 ns | 0.0686 ns | 0.0535 ns |
|                             LINQ_Method_Syntax_Over_Array |  5.205 ns | 0.0393 ns | 0.0328 ns |
|                             LINQ_Query_Syntax_Over_Array_ | 91.563 ns | 0.5235 ns | 0.4641 ns |
|                      Foreach_Over_Span_With_Sum_As_Double |  5.289 ns | 0.0607 ns | 0.0507 ns |
|      For_Over_Span_With_Sum_As_Double_Length_Recalculated |  5.309 ns | 0.0915 ns | 0.0764 ns |
| For_Over_Span_With_Sum_As_Double_Length_PreCalculted_long |  6.457 ns | 0.1397 ns | 0.1958 ns |
|  For_Over_Span_With_Sum_As_Double_Length_PreCalculted_int |  5.983 ns | 0.1415 ns | 0.1390 ns |
