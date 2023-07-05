``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-preview.4.23260.5
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                                                    Method |      Mean |     Error |    StdDev |
|---------------------------------------------------------- |----------:|----------:|----------:|
|                          Foreach_Over_Array_Sum_As_Double |  5.130 ns | 0.0814 ns | 0.0762 ns |
|          For_Over_Array_Sum_As_Double_Length_Recalculated |  6.312 ns | 0.1430 ns | 0.1957 ns |
|     For_Over_Array_Sum_As_Double_Length_PreCalculted_long |  8.164 ns | 0.1350 ns | 0.1197 ns |
|      For_Over_Array_Sum_As_Double_Length_PreCalculted_int |  8.225 ns | 0.1559 ns | 0.1382 ns |
|                             LINQ_Method_Syntax_Over_Array |  5.092 ns | 0.0393 ns | 0.0328 ns |
|                             LINQ_Query_Syntax_Over_Array_ | 96.295 ns | 1.9629 ns | 3.4890 ns |
|                      Foreach_Over_Span_With_Sum_As_Double |  5.489 ns | 0.0785 ns | 0.0696 ns |
|      For_Over_Span_With_Sum_As_Double_Length_Recalculated |  5.510 ns | 0.1399 ns | 0.2007 ns |
| For_Over_Span_With_Sum_As_Double_Length_PreCalculted_long |  6.413 ns | 0.1487 ns | 0.2359 ns |
|  For_Over_Span_With_Sum_As_Double_Length_PreCalculted_int |  6.280 ns | 0.1240 ns | 0.1739 ns |
