// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<ListCapacity>();

[SimpleJob(RuntimeMoniker.Net70)]
[MarkdownExporterAttribute.GitHub]
public class ListCapacity
{
    [Params(5, 100, 500, 1000, 10000, 50000, 500000, 1000000)]
    public int Records;

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
}