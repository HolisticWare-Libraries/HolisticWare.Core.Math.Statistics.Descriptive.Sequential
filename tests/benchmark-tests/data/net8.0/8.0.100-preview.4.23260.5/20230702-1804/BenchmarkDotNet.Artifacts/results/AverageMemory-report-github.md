``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-preview.4.23260.5
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
|                            Method |     Mean |     Error |    StdDev |
|---------------------------------- |---------:|----------:|----------:|
|      For_Length_Recalculated_Span | 2.776 ns | 0.0607 ns | 0.0507 ns |
| For_Length_PreCalculted_long_Span | 3.345 ns | 0.0963 ns | 0.0853 ns |
|  For_Length_PreCalculted_int_Span | 3.049 ns | 0.0894 ns | 0.1469 ns |
