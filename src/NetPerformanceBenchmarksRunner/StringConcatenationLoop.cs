using System.Runtime.CompilerServices;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[SimpleJob(RuntimeMoniker.Net70)]
[MarkdownExporterAttribute.GitHub]
[MemoryDiagnoser]
public class StringConcatenationLoop
{
    [Benchmark]
    public string StringBuilder()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < 100; i++)
        {
            sb.Append(i);
        }
        return sb.ToString();
    }

    [Benchmark]
    public string StringConcat()
    {
        string result = string.Empty;
        for (int i = 0; i < 100; i++)
        {
            result += i;
        }
        return result;
    }

    [Benchmark]
    public string StringInterpolation()
    {
        string result = string.Empty;
        for (int i = 0; i < 100; i++)
        {
            result += $"{i}";
        }
        return result;
    }

    [Benchmark]
    public string StringInterpolationHandler()
    {
        var handler = new DefaultInterpolatedStringHandler(0, 100);
        for (int i = 0; i < 100; i++)
        {
            handler.AppendFormatted(i);
        }
        return handler.ToStringAndClear();
    }
}