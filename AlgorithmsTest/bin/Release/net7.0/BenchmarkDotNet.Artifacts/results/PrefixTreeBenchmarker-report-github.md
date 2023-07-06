``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i3-3220 CPU 3.30GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.201
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX
  Job-JGXSTV : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX

EvaluateOverhead=False  IterationCount=8  WarmupCount=1  

```
| Method |      Mean |     Error |   StdDev |
|------- |----------:|----------:|---------:|
|     F1 | 173.75 ns | 21.161 ns | 9.395 ns |
|     F2 |  11.28 ns |  0.262 ns | 0.137 ns |
|     F3 |  10.22 ns |  0.121 ns | 0.063 ns |
