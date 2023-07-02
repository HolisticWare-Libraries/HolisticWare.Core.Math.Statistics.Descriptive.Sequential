``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.302
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
|                       Method |      Mean |     Error |    StdDev |
|----------------------------- |----------:|----------:|----------:|
|                      Foreach |  2.954 ns | 0.0806 ns | 0.0989 ns |
|      For_Length_Recalculated |  3.574 ns | 0.0869 ns | 0.0771 ns |
| For_Length_PreCalculted_long |  4.869 ns | 0.0579 ns | 0.0483 ns |
|  For_Length_PreCalculted_int |  4.945 ns | 0.1036 ns | 0.0918 ns |
|           LINQ_Method_Syntax | 39.440 ns | 0.4411 ns | 0.3911 ns |
|            LINQ_Query_Syntax | 74.214 ns | 1.0654 ns | 0.8897 ns |
