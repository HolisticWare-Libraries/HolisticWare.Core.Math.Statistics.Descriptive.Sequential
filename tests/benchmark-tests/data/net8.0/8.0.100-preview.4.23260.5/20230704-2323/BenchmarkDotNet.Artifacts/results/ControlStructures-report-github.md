``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-preview.4.23260.5
  [Host]     : .NET 8.0.0 (8.0.23.25905), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.25905), X64 RyuJIT AVX2


```
|                 Method |     Mean |     Error |    StdDev |
|----------------------- |---------:|----------:|----------:|
|     If_PatternMatching | 8.838 ns | 0.1263 ns | 0.1055 ns |
| If_RelationalOperators | 7.560 ns | 0.1658 ns | 0.1551 ns |
