# .NET Performance Benchmarks
This repository contains benchmarks for various situations we usually meet when developing libraries or business features

# List capacity

```csharp
[Benchmark]
public void ListDynamicCapacity()
{
    var list = new List<int>();

    for (int i = 0; i < Records; i++)
    {
        list.Add(i);
    }
}

[Benchmark]
public void ListPlannedCapacity()
{
    var list = new List<int>(Records);

    for (int i = 0; i < Records; i++)
    {
        list.Add(i);
    }
}

[Benchmark]
public void HashSetDynamicCapacity()
{
    var hashSet = new HashSet<int>();

    for (int i = 0; i < Records; i++)
    {
        hashSet.Add(i);
    }
}

[Benchmark]
public void HashSetPlannedCapacity()
{
    var hashSet = new HashSet<int>(Records);

    for (int i = 0; i < Records; i++)
    {
        hashSet.Add(i);
    }
}


[Benchmark]
public void DictionaryDynamicCapacity()
{
    var map = new Dictionary<int, int>();

    for (int i = 0; i < Records; i++)
    {
        map.Add(i, i);
    }
}

[Benchmark]
public void DictionaryPlannedCapacity()
{
    var map = new Dictionary<int, int>(Records);

    for (int i = 0; i < Records; i++)
    {
        map.Add(i, i);
    }
}
```

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
AMD Ryzen 7 5700U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.202
  [Host]   : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2

Job=.NET 7.0  Runtime=.NET 7.0  

```
|                    Method | Records |             Mean |          Error |         StdDev |           Median |
|-------------------------- |-------- |-----------------:|---------------:|---------------:|-----------------:|
|       **ListDynamicCapacity** |       **5** |         **40.75 ns** |       **1.884 ns** |       **5.556 ns** |         **39.70 ns** |
|       ListPlannedCapacity |       5 |         21.18 ns |       0.680 ns |       2.006 ns |         20.85 ns |
|    HashSetDynamicCapacity |       5 |         84.91 ns |       2.456 ns |       7.241 ns |         83.85 ns |
|    HashSetPlannedCapacity |       5 |         51.08 ns |       1.050 ns |       2.282 ns |         50.80 ns |
| DictionaryDynamicCapacity |       5 |         81.54 ns |       1.696 ns |       4.865 ns |         81.02 ns |
| DictionaryPlannedCapacity |       5 |         50.94 ns |       0.984 ns |       2.160 ns |         50.68 ns |
|       **ListDynamicCapacity** |     **100** |        **272.52 ns** |       **5.503 ns** |      **12.421 ns** |        **270.45 ns** |
|       ListPlannedCapacity |     100 |        202.92 ns |       4.112 ns |      10.087 ns |        201.51 ns |
|    HashSetDynamicCapacity |     100 |      1,288.31 ns |      26.793 ns |      76.875 ns |      1,281.67 ns |
|    HashSetPlannedCapacity |     100 |        707.05 ns |      14.003 ns |      23.007 ns |        710.51 ns |
| DictionaryDynamicCapacity |     100 |      1,385.97 ns |      32.725 ns |      93.894 ns |      1,384.14 ns |
| DictionaryPlannedCapacity |     100 |        694.51 ns |      13.325 ns |      36.476 ns |        683.58 ns |
|       **ListDynamicCapacity** |     **500** |      **1,188.70 ns** |      **23.107 ns** |      **34.585 ns** |      **1,178.40 ns** |
|       ListPlannedCapacity |     500 |        952.47 ns |      18.265 ns |      18.757 ns |        950.53 ns |
|    HashSetDynamicCapacity |     500 |      5,526.30 ns |     107.074 ns |     109.958 ns |      5,537.38 ns |
|    HashSetPlannedCapacity |     500 |      3,151.82 ns |      62.097 ns |     138.888 ns |      3,122.12 ns |
| DictionaryDynamicCapacity |     500 |      5,803.73 ns |     115.927 ns |     277.755 ns |      5,761.82 ns |
| DictionaryPlannedCapacity |     500 |      3,396.08 ns |      91.823 ns |     263.457 ns |      3,330.80 ns |
|       **ListDynamicCapacity** |    **1000** |      **2,081.16 ns** |      **36.560 ns** |      **59.038 ns** |      **2,058.62 ns** |
|       ListPlannedCapacity |    1000 |      1,787.62 ns |       8.797 ns |       6.868 ns |      1,787.16 ns |
|    HashSetDynamicCapacity |    1000 |     11,807.19 ns |     398.262 ns |   1,155.431 ns |     11,627.18 ns |
|    HashSetPlannedCapacity |    1000 |      6,924.18 ns |     252.340 ns |     736.089 ns |      6,673.29 ns |
| DictionaryDynamicCapacity |    1000 |     14,251.56 ns |     683.284 ns |   1,971.431 ns |     13,670.23 ns |
| DictionaryPlannedCapacity |    1000 |      6,810.31 ns |     151.379 ns |     414.398 ns |      6,627.73 ns |
|       **ListDynamicCapacity** |   **10000** |     **23,663.79 ns** |     **469.245 ns** |   **1,142.208 ns** |     **23,321.68 ns** |
|       ListPlannedCapacity |   10000 |     18,476.58 ns |     207.464 ns |     194.062 ns |     18,499.92 ns |
|    HashSetDynamicCapacity |   10000 |    199,776.94 ns |   3,095.309 ns |   3,440.428 ns |    197,831.69 ns |
|    HashSetPlannedCapacity |   10000 |    109,954.32 ns |   2,165.511 ns |   5,628.452 ns |    106,991.15 ns |
| DictionaryDynamicCapacity |   10000 |    245,802.72 ns |   1,517.762 ns |   1,345.457 ns |    245,528.39 ns |
| DictionaryPlannedCapacity |   10000 |    120,521.79 ns |   2,159.514 ns |   2,120.932 ns |    120,016.35 ns |
|       **ListDynamicCapacity** |   **50000** |    **247,784.16 ns** |   **3,713.836 ns** |   **6,406.184 ns** |    **245,783.25 ns** |
|       ListPlannedCapacity |   50000 |    159,812.03 ns |   4,293.408 ns |  11,607.479 ns |    154,513.75 ns |
|    HashSetDynamicCapacity |   50000 |    934,026.80 ns |  18,105.297 ns |  21,553.068 ns |    929,356.45 ns |
|    HashSetPlannedCapacity |   50000 |    563,706.57 ns |   4,572.380 ns |   3,818.144 ns |    562,586.96 ns |
| DictionaryDynamicCapacity |   50000 |  1,081,596.34 ns |  14,208.616 ns |  13,290.748 ns |  1,082,924.61 ns |
| DictionaryPlannedCapacity |   50000 |    544,375.69 ns |   4,993.473 ns |   4,169.776 ns |    543,540.67 ns |
|       **ListDynamicCapacity** |  **500000** |  **2,444,488.78 ns** |  **47,331.468 ns** |  **44,273.884 ns** |  **2,451,130.47 ns** |
|       ListPlannedCapacity |  500000 |  1,519,819.93 ns |   7,677.266 ns |  11,010.506 ns |  1,521,125.10 ns |
|    HashSetDynamicCapacity |  500000 |  9,942,221.13 ns | 194,955.615 ns | 216,692.650 ns |  9,921,195.31 ns |
|    HashSetPlannedCapacity |  500000 |  4,757,468.63 ns |  94,990.912 ns | 133,163.992 ns |  4,754,979.69 ns |
| DictionaryDynamicCapacity |  500000 | 10,885,350.22 ns | 188,404.299 ns | 167,015.504 ns | 10,919,909.38 ns |
| DictionaryPlannedCapacity |  500000 |  5,105,042.73 ns | 101,784.490 ns | 203,274.625 ns |  5,048,456.25 ns |
|       **ListDynamicCapacity** | **1000000** |  **5,174,167.19 ns** |  **97,128.425 ns** | **115,624.481 ns** |  **5,175,618.75 ns** |
|       ListPlannedCapacity | 1000000 |  3,031,622.27 ns |  26,813.417 ns |  20,934.152 ns |  3,023,960.35 ns |
|    HashSetDynamicCapacity | 1000000 | 19,238,261.70 ns | 362,060.333 ns | 853,418.802 ns | 19,114,371.88 ns |
|    HashSetPlannedCapacity | 1000000 |  8,784,909.17 ns | 114,459.078 ns | 107,065.093 ns |  8,782,306.25 ns |
| DictionaryDynamicCapacity | 1000000 | 21,203,501.04 ns | 414,480.841 ns | 387,705.636 ns | 21,223,450.00 ns |
| DictionaryPlannedCapacity | 1000000 | 10,092,021.22 ns | 178,453.157 ns | 198,350.211 ns | 10,021,425.00 ns |

*Recommendation*: always specify capacity if you know planned size