using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[SimpleJob(RuntimeMoniker.Net70)]
[MarkdownExporterAttribute.GitHub]
[MemoryDiagnoser]
public class Allocation
{
    [Params(5, 100, 500, 1000, 10000, 50000, 500000, 1000000)]
    public int Records;

    [Benchmark]
    public void NewList()
    {
        var list = new List<int>(Records);
    }

    [Benchmark]
    public void NewArray()
    {
        var array = new int[Records];
    }

    [Benchmark]
    public void NewDictionary()
    {
        var dictionary = new Dictionary<int, int>(Records);
    }

    [Benchmark]
    public void NewHashSet()
    {
        var hashSet = new HashSet<int>(Records);
    }

    [Benchmark]
    public void NewEnumerable()
    {
        var enumerable = Enumerable.Range(0, Records);
    }
}