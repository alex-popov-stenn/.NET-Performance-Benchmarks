using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[SimpleJob(RuntimeMoniker.Net70)]
[MarkdownExporterAttribute.GitHub]
public class Capacity
{
    [Params(5, 100, 500, 1000, 10000, 50000, 500000, 1000000)]
    public int Records;

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
}