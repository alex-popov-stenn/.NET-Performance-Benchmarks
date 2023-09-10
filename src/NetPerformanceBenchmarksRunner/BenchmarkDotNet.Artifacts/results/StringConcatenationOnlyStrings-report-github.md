```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
AMD Ryzen 7 5700U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.202
  [Host]   : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2

Job=.NET 7.0  Runtime=.NET 7.0  

```
|                           Method |      Mean |    Error |   StdDev |    Median |   Gen0 | Allocated |
|--------------------------------- |----------:|---------:|---------:|----------:|-------:|----------:|
|                     StringFormat |  80.89 ns | 1.662 ns | 1.847 ns |  79.89 ns | 0.0459 |      96 B |
|              StringInterpolation |  44.67 ns | 0.319 ns | 0.283 ns |  44.70 ns | 0.0459 |      96 B |
|                       StringJoin |  48.15 ns | 0.168 ns | 0.141 ns |  48.13 ns | 0.0765 |     160 B |
|                    StringBuilder |  80.18 ns | 1.538 ns | 3.656 ns |  78.35 ns | 0.2104 |     440 B |
| DefaultInterpolatedStringHandler |  46.24 ns | 0.931 ns | 1.108 ns |  46.23 ns | 0.0459 |      96 B |
|              EnumerableAggregate | 135.90 ns | 2.160 ns | 1.686 ns | 135.51 ns | 0.2563 |     536 B |
