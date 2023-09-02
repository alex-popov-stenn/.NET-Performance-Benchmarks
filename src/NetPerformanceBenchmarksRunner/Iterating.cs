using System.Collections;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[SimpleJob(RuntimeMoniker.Net70)]
[MarkdownExporterAttribute.GitHub]
[MemoryDiagnoser]
public class Iterating
{
    [Params(5, 100, 500, 1000, 10000, 50000, 500000, 1000000)]
    public int Records;

    private int[] array;
    private List<int> list;
    private Dictionary<int, int> dictionary;
    private HashSet<int> hashSet;
    private IEnumerable<int> enumerable;

    [GlobalSetup]
    public void Setup()
    {
        var source = Enumerable.Range(0, Records);

        array = source.ToArray();
        list = new List<int>(source);
        dictionary = source.ToDictionary(x => x, x => x);
        hashSet = new HashSet<int>(source);
        enumerable = source;
    }

    [Benchmark]
    public void ListFor()
    {
        for (int i = 0; i < list.Count; i++)
        {
        }
    }

    [Benchmark]
    public void ListForeach()
    {
        foreach (var item in list)
        {
        }
    }

    [Benchmark]
    public void ListAsGenericEnumerable()
    {
        foreach (var item in list.AsEnumerable())
        {
        }
    }

    [Benchmark]
    public void ListAsPlainEnumerable()
    {
        IEnumerable enumerable = list;

        foreach (var item in enumerable)
        {
        }
    }

    [Benchmark]
    public void ArrayFor()
    {
        for (int i = 0; i < array.Length; i++)
        {
        }
    }

    [Benchmark]
    public void ArrayForeach()
    {
        foreach (var item in array)
        {
        }
    }

    [Benchmark]
    public void DictionaryForeach()
    {
        foreach (var item in dictionary)
        {
        }
    }

    [Benchmark]
    public void HashSetForeach()
    {
        foreach (var item in hashSet)
        {
        }
    }

    [Benchmark]
    public void GenericEnumerableForeach()
    {
        foreach (var item in enumerable)
        {
        }
    }

    [Benchmark]
    public void PlainEnumerableForeach()
    {
        var e = (IEnumerable)enumerable;

        foreach (var item in e)
        {
        }
    }
}