``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-preview.4.23260.5
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
|                 Method |      Mean |     Error |    StdDev |
|----------------------- |----------:|----------:|----------:|
|     If_PatternMatching | 10.553 ns | 0.2331 ns | 0.3630 ns |
| If_RelationalOperators |  8.632 ns | 0.1696 ns | 0.1503 ns |
