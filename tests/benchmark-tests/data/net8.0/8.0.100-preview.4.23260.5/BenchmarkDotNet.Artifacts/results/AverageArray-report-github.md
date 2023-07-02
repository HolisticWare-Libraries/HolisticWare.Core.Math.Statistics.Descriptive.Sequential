``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-preview.4.23260.5
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
|                       Method |      Mean |     Error |    StdDev |
|----------------------------- |----------:|----------:|----------:|
|                      Foreach |  2.825 ns | 0.0839 ns | 0.0932 ns |
|      For_Length_Recalculated |  3.400 ns | 0.0573 ns | 0.0478 ns |
| For_Length_PreCalculted_long |  4.775 ns | 0.1086 ns | 0.2992 ns |
|  For_Length_PreCalculted_int |  4.672 ns | 0.1127 ns | 0.1055 ns |
|           LINQ_Method_Syntax | 38.845 ns | 0.7963 ns | 1.3947 ns |
|            LINQ_Query_Syntax | 69.964 ns | 1.4160 ns | 1.5738 ns |
