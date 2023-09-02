using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[SimpleJob(RuntimeMoniker.Net70)]
[MarkdownExporterAttribute.GitHub]
public class Capacity
{
    [Params(5, 100, 500, 1000, 10000, 50000, 500000, 1000000)]
    public int Records;


    private List<int> listWithCapacity;
    private List<int> listWithoutCapacity;
    private Dictionary<int, int> dictionaryWithCapacity;
    private Dictionary<int, int> dictionaryWithoutCapacity;
    private HashSet<int> hashSetWithCapacity;
    private HashSet<int> hashSetWithoutCapacity;

    [GlobalSetup]
    public void Setup()
    {
        listWithCapacity = new List<int>(Records);
        listWithoutCapacity = new List<int>();
        dictionaryWithCapacity = new Dictionary<int, int>(Records);
        dictionaryWithoutCapacity = new Dictionary<int, int>();
        hashSetWithCapacity = new HashSet<int>(Records);
        hashSetWithoutCapacity = new HashSet<int>();
    }

    [Benchmark]
    public void ListDynamicCapacity()
    {
        for (int i = 0; i < Records; i++)
        {
            listWithoutCapacity.Add(i);
        }
    }

    [Benchmark]
    public void ListPlannedCapacity()
    {
        for (int i = 0; i < Records; i++)
        {
            listWithCapacity.Add(i);
        }
    }

    [Benchmark]
    public void HashSetDynamicCapacity()
    {
        for (int i = 0; i < Records; i++)
        {
            hashSetWithoutCapacity.Add(i);
        }
    }

    [Benchmark]
    public void HashSetPlannedCapacity()
    {
        for (int i = 0; i < Records; i++)
        {
            hashSetWithCapacity.Add(i);
        }
    }


    [Benchmark]
    public void DictionaryDynamicCapacity()
    {
        for (int i = 0; i < Records; i++)
        {
            dictionaryWithoutCapacity.Add(i, i);
        }
    }

    [Benchmark]
    public void DictionaryPlannedCapacity()
    {
        for (int i = 0; i < Records; i++)
        {
            dictionaryWithCapacity.Add(i, i);
        }
    }
}