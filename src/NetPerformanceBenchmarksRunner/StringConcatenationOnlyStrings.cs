using System.Runtime.CompilerServices;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[SimpleJob(RuntimeMoniker.Net70)]
[MarkdownExporterAttribute.GitHub]
[MemoryDiagnoser]
public class StringConcatenationOnlyStrings
{
    [Benchmark]
    public string StringFormat()
    {
        string orderAmount = "150";
        string orderNumber = "ORDER-13";
        return string.Format("Order number {0} has {1} items.", orderNumber, orderAmount);
    }

    [Benchmark]
    public string StringInterpolation()
    {
        string orderAmount = "150";
        string orderNumber = "ORDER-13";
        return $"Order number {orderNumber} has {orderAmount} items.";
    }

    public string StringConcat()
    {
        string orderAmount = "150";
        string orderNumber = "ORDER-13";
        return "Order number " + orderNumber + " has " + orderAmount + " items.";
    }

    [Benchmark]
    public string StringJoin()
    {
        string orderAmount = "150";
        string orderNumber = "ORDER-13";
        return string.Join(" ", "Order number", orderNumber, "has", orderAmount, "items.");
    }

    [Benchmark]
    public string StringBuilder()
    {
        string orderAmount = "150";
        string orderNumber = "ORDER-13";
        var sb = new StringBuilder();
        sb.Append("Order number ");
        sb.Append(orderNumber);
        sb.Append(" has ");
        sb.Append(orderAmount);
        sb.Append(" items.");
        return sb.ToString();
    }

    [Benchmark]
    public string DefaultInterpolatedStringHandler()
    {
        string orderAmount = "150";
        string orderNumber = "ORDER-13";
        DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
        defaultInterpolatedStringHandler.AppendLiteral("Order number ");
        defaultInterpolatedStringHandler.AppendFormatted(orderNumber);
        defaultInterpolatedStringHandler.AppendLiteral(" has ");
        defaultInterpolatedStringHandler.AppendFormatted(orderAmount);
        defaultInterpolatedStringHandler.AppendLiteral(" items.");
        return defaultInterpolatedStringHandler.ToStringAndClear();
    }

    [Benchmark]
    public string EnumerableAggregate()
    {
        string orderAmount = "150";
        string orderNumber = "ORDER-13";
        return new string[] { "Order number ", orderNumber, " has ", orderAmount, " items." }.Aggregate(new StringBuilder(), (sb, s) => sb.Append(s)).ToString();
    }
}