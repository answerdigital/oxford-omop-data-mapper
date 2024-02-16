using Microsoft.Extensions.Logging;
using NSubstitute;
using OmopTransformer.Annotations;
using OmopTransformer.Omop;
using OmopTransformer.Transformation;
using System.Diagnostics.CodeAnalysis;

namespace OmopTransformerTests.Transformation;

[TestClass]
public class TransformationTests
{
    [TestMethod]
    public void TestTransformation()
    {
        var sourceClass =
            new SourceClass
            {
                Number = 123,
                Text = "hello world",
                Line1 = "line 1",
                Line2 = "line 2",
                ColourName = "blue"
            };

        var testConcept = new TestConcept(sourceClass);

        var logger = Substitute.For<ILogger<RecordTransformer>>();

        new RecordTransformer(logger, null!, null!, null!).Transform(testConcept);

        Assert.AreEqual(testConcept.Text, "hello world");
        Assert.AreEqual(testConcept.JoinedText, "line 1\r\nline 2");
        Assert.AreEqual(1, testConcept.ColourId);
        Assert.AreEqual(123, testConcept.ConstantNumber);
    }
}

internal class SourceClass
{
    public string? Text { get; set; }
    public int? Number { get; set; }

    public string? Line1 { get; set; }

    public string? Line2 { get; set; }
    
    public string? ColourName { get; set; }
}

internal class TestConcept : OmopTestConcept<SourceClass>
{
    public TestConcept(SourceClass source) : base(source)
    {
    }

    [CopyValue(nameof(Source.Text))]
    public override string? Text { get; set; }

    [Transform(typeof(TextDeliminator), nameof(Source.Line1), nameof(Source.Line2))]
    public override string? JoinedText { get; set; }
    
    [Transform(typeof(ColourIdTransformer), nameof(SourceClass.ColourName))]
    public override int? ColourId { get; set; }

    [ConstantValue(123, "")]
    public override int? ConstantNumber { get; set; }
    
    
}

internal class ColourIdTransformer : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "blue", new ValueWithNote("1", "") },
            { "red", new ValueWithNote("2", "") },
        };

    public string[] ColumnNotes { get; } = ["colours"];
}

internal abstract class OmopTestConcept<T> : IOmopRecord<T>
{
    protected OmopTestConcept([DisallowNull] T source)
    {
        Source = source ?? throw new ArgumentNullException(nameof(source));
    }
    
    public virtual int? ColourId { get; set; }

    public virtual string? Text { get; set; }

    public virtual string? JoinedText { get; set; }

    public virtual int? ConstantNumber { get; set; }

    public string OmopTargetTypeDescription => "";
    public T? Source { get; set; }
}