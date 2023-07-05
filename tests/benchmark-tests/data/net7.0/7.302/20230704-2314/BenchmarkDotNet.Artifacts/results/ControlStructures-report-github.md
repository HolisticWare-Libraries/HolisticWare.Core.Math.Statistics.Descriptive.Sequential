``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-preview.4.23260.5
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                 Method |     Mean |     Error |    StdDev |
|----------------------- |---------:|----------:|----------:|
|     If_PatternMatching | 7.234 ns | 0.1751 ns | 0.2455 ns |
| If_RelationalOperators | 6.846 ns | 0.1359 ns | 0.1205 ns |
