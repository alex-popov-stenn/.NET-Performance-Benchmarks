# .NET Performance Benchmarks
This repository contains benchmarks for various situations

# List capacity

```csharp
[Benchmark]
public void AddToListWithoutInitializedCapacity()
{
    var list = new List<int>();

    for (int i = 0; i < Records; i++)
    {
        list.Add(i);
    }
}

[Benchmark]
public void AddToListWithInitializedCapacity()
{
    var list = new List<int>(Records);

    for (int i = 0; i < Records; i++)
    {
        list.Add(i);
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
|                              Method | Records |            Mean |         Error |         StdDev |
|------------------------------------ |-------- |----------------:|--------------:|---------------:|
| **AddToListWithoutInitializedCapacity** |       **5** |        **30.28 ns** |      **0.073 ns** |       **0.061 ns** |
|    AddToListWithInitializedCapacity |       5 |        14.77 ns |      0.055 ns |       0.043 ns |
| **AddToListWithoutInitializedCapacity** |     **100** |       **255.01 ns** |      **5.076 ns** |       **5.642 ns** |
|    AddToListWithInitializedCapacity |     100 |       207.62 ns |      0.311 ns |       0.243 ns |
| **AddToListWithoutInitializedCapacity** |     **500** |     **1,129.64 ns** |     **19.372 ns** |      **25.189 ns** |
|    AddToListWithInitializedCapacity |     500 |       900.18 ns |     17.493 ns |      15.507 ns |
| **AddToListWithoutInitializedCapacity** |    **1000** |     **2,013.68 ns** |     **25.052 ns** |      **26.806 ns** |
|    AddToListWithInitializedCapacity |    1000 |     1,750.14 ns |      8.072 ns |       7.551 ns |
| **AddToListWithoutInitializedCapacity** |   **10000** |    **20,879.05 ns** |    **210.560 ns** |     **175.827 ns** |
|    AddToListWithInitializedCapacity |   10000 |    17,243.98 ns |     10.600 ns |       9.397 ns |
| **AddToListWithoutInitializedCapacity** |   **50000** |   **236,668.83 ns** |    **824.248 ns** |     **771.002 ns** |
|    AddToListWithInitializedCapacity |   50000 |   148,223.85 ns |  1,457.529 ns |   1,363.374 ns |
| **AddToListWithoutInitializedCapacity** |  **500000** | **2,391,102.57 ns** | **46,899.070 ns** |  **89,230.354 ns** |
|    AddToListWithInitializedCapacity |  500000 | 1,489,341.31 ns | 11,320.957 ns |  10,035.733 ns |
| **AddToListWithoutInitializedCapacity** | **1000000** | **5,037,593.54 ns** | **97,038.301 ns** | **132,827.122 ns** |
|    AddToListWithInitializedCapacity | 1000000 | 3,005,693.33 ns | 35,839.924 ns |  33,524.687 ns |