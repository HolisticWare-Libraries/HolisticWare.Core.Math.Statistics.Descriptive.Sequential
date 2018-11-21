``` ini

BenchmarkDotNet=v0.10.14, OS=macOS High Sierra 10.13.4 (17E199) [Darwin 17.5.0]
Intel Core i7-3740QM CPU 2.70GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.300-preview1-008174
  [Host] : .NET Core 2.0.5 (CoreCLR 4.6.0.0, CoreFX 4.6.26018.01), 64bit RyuJIT

Job=InProcess  Toolchain=InProcessToolchain  

```
|               Method |     Mean |     Error |    StdDev |
|--------------------- |---------:|----------:|----------:|
| Array_MeanArithmetic | 30.79 us | 0.6132 us | 0.8393 us |
