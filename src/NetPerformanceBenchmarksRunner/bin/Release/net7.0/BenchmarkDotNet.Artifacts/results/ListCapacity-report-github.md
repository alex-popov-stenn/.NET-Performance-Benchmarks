```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
AMD Ryzen 7 5700U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.202
  [Host]   : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2 [AttachedDebugger]
  .NET 7.0 : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2

Job=.NET 7.0  Runtime=.NET 7.0  

```
|                              Method | Records |            Mean |         Error |        StdDev |          Median |
|------------------------------------ |-------- |----------------:|--------------:|--------------:|----------------:|
| **AddToListWithoutInitializedCapacity** |       **5** |        **34.50 ns** |      **0.694 ns** |      **0.949 ns** |        **34.55 ns** |
|    AddToListWithInitializedCapacity |       5 |        32.98 ns |      0.690 ns |      1.945 ns |        32.43 ns |
| **AddToListWithoutInitializedCapacity** |     **100** |       **271.85 ns** |      **3.467 ns** |      **2.895 ns** |       **270.49 ns** |
|    AddToListWithInitializedCapacity |     100 |       264.41 ns |      4.371 ns |      3.650 ns |       263.70 ns |
| **AddToListWithoutInitializedCapacity** |     **500** |     **1,157.94 ns** |      **9.633 ns** |      **8.044 ns** |     **1,156.64 ns** |
|    AddToListWithInitializedCapacity |     500 |     1,187.52 ns |     18.783 ns |     16.651 ns |     1,191.85 ns |
| **AddToListWithoutInitializedCapacity** |    **1000** |     **2,251.43 ns** |     **41.854 ns** |     **37.103 ns** |     **2,244.11 ns** |
|    AddToListWithInitializedCapacity |    1000 |     2,211.72 ns |     10.837 ns |      9.049 ns |     2,209.38 ns |
| **AddToListWithoutInitializedCapacity** |   **10000** |    **23,194.42 ns** |    **460.437 ns** |    **806.419 ns** |    **22,766.70 ns** |
|    AddToListWithInitializedCapacity |   10000 |    22,978.43 ns |    405.286 ns |    379.104 ns |    22,897.98 ns |
| **AddToListWithoutInitializedCapacity** |   **50000** |   **256,594.68 ns** |  **1,174.261 ns** |  **1,098.404 ns** |   **256,980.71 ns** |
|    AddToListWithInitializedCapacity |   50000 |   261,751.19 ns |  5,069.581 ns |  6,767.745 ns |   259,155.47 ns |
| **AddToListWithoutInitializedCapacity** |  **500000** | **2,512,333.83 ns** |  **6,755.415 ns** |  **5,641.078 ns** | **2,513,889.06 ns** |
|    AddToListWithInitializedCapacity |  500000 | 2,510,444.62 ns | 28,210.739 ns | 23,557.245 ns | 2,502,859.77 ns |
| **AddToListWithoutInitializedCapacity** | **1000000** | **5,264,144.22 ns** | **73,913.290 ns** | **69,138.537 ns** | **5,259,989.84 ns** |
|    AddToListWithInitializedCapacity | 1000000 | 5,264,320.98 ns | 86,617.878 ns | 76,784.493 ns | 5,257,204.30 ns |
