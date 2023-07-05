``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.302
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
|                            Method |     Mean |     Error |    StdDev |
|---------------------------------- |---------:|----------:|----------:|
|      For_Length_Recalculated_Span | 3.032 ns | 0.0923 ns | 0.1567 ns |
| For_Length_PreCalculted_long_Span | 3.424 ns | 0.0721 ns | 0.0563 ns |
|  For_Length_PreCalculted_int_Span | 2.993 ns | 0.0810 ns | 0.0718 ns |
