```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
AMD Ryzen 7 5700U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.202
  [Host]   : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2

Job=.NET 7.0  Runtime=.NET 7.0  

```
|                           Method |      Mean |    Error |   StdDev |   Gen0 | Allocated |
|--------------------------------- |----------:|---------:|---------:|-------:|----------:|
|                     StringFormat |  79.34 ns | 1.002 ns | 0.783 ns | 0.0573 |     120 B |
|              StringInterpolation |  54.01 ns | 0.922 ns | 0.906 ns | 0.0459 |      96 B |
|                     StringConcat |  51.08 ns | 0.208 ns | 0.173 ns | 0.0918 |     192 B |
|                       StringJoin |  74.55 ns | 0.593 ns | 0.526 ns | 0.1032 |     216 B |
|                    StringBuilder |  84.85 ns | 0.311 ns | 0.305 ns | 0.2104 |     440 B |
| DefaultInterpolatedStringHandler |  50.56 ns | 0.431 ns | 0.360 ns | 0.0459 |      96 B |
|              EnumerableAggregate | 150.56 ns | 1.761 ns | 1.648 ns | 0.2716 |     568 B |
