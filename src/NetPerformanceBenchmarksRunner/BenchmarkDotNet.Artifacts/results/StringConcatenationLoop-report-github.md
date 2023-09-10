```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
AMD Ryzen 7 5700U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.202
  [Host]   : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2

Job=.NET 7.0  Runtime=.NET 7.0  

```
|                     Method |       Mean |     Error |    StdDev |    Gen0 | Allocated |
|--------------------------- |-----------:|----------:|----------:|--------:|----------:|
|              StringBuilder |   837.6 ns |  16.78 ns |  47.88 ns |  0.6733 |    1408 B |
|               StringConcat | 2,774.6 ns |  55.47 ns | 106.87 ns | 11.3487 |   23736 B |
|        StringInterpolation | 6,534.7 ns | 170.19 ns | 491.05 ns | 11.4594 |   23976 B |
| StringInterpolationHandler |   681.5 ns |  13.69 ns |  33.05 ns |  0.1945 |     408 B |