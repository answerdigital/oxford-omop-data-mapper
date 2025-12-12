using Microsoft.Extensions.Logging;
using NSubstitute;
using OmopTransformer.ConceptResolution;

namespace OmopTransformerTests.ConceptResolution;

[TestClass]
public class StandardConceptResolverTests
{
    private static StandardConceptResolver CreateResolver(Dictionary<int, IGrouping<int, ConceptCodeMapRow>> mappings)
    {
        var logger = Substitute.For<ILogger<StandardConceptResolver>>();
        var provider = Substitute.For<IStandardConceptResolverDataProvider>();
        provider.GetMappings().Returns(mappings);
        provider.GetDevices().Returns(new Dictionary<int, IReadOnlyCollection<int>>());
        return new StandardConceptResolver(logger, provider);
    }

    private static IGrouping<int, ConceptCodeMapRow> Group(int key, params ConceptCodeMapRow[] rows)
    {
        return new Grouping<int, ConceptCodeMapRow>(key, rows);
    }

    [TestMethod]
    public void NoDomain_UnknownConcept_Returns0()
    {
        var mappings = new Dictionary<int, IGrouping<int, ConceptCodeMapRow>>
        {
            {
                678,
                Group(678,
                    new ConceptCodeMapRow { source_concept_id = 678, target_concept_id = 678, source_domain_id = "Condition", target_domain_id = "Condition", mapped_from_standard = 1 })
            }
        };
        var resolver = CreateResolver(mappings);

        CollectionAssert.AreEqual(new[] { 0 }, resolver.GetConcepts(123, null));
    }

    [TestMethod]
    public void NoDomain_StandardConcept_ReturnsSelf()
    {
        var mappings = new Dictionary<int, IGrouping<int, ConceptCodeMapRow>>
        {
            {
                678,
                Group(678,
                    new ConceptCodeMapRow { source_concept_id = 678, target_concept_id = 678, source_domain_id = "Condition", target_domain_id = "Condition", mapped_from_standard = 1 })
            }
        };
        var resolver = CreateResolver(mappings);
        CollectionAssert.AreEqual(new[] { 678 }, resolver.GetConcepts(678, null));
    }

    [TestMethod]
    public void NoDomain_NonStandard_NoRelationship_Returns0()
    {
        var mappings = new Dictionary<int, IGrouping<int, ConceptCodeMapRow>>
        {
            {
                123,
                Group(123,
                    new ConceptCodeMapRow { source_concept_id = 123, target_concept_id = null, source_domain_id = "Procedure", target_domain_id = null, mapped_from_standard = 0 })
            }
        };
        var resolver = CreateResolver(mappings);
        CollectionAssert.AreEqual(new[] { 0 }, resolver.GetConcepts(123, null));
    }

    [TestMethod]
    public void NoDomain_NonStandard_WithRelationship_ReturnsTarget()
    {
        var mappings = new Dictionary<int, IGrouping<int, ConceptCodeMapRow>>
        {
            {
                123,
                Group(123,
                    new ConceptCodeMapRow { source_concept_id = 123, target_concept_id = 456, source_domain_id = "Procedure", target_domain_id = "Procedure", mapped_from_standard = 0 })
            }
        };
        var resolver = CreateResolver(mappings);
        CollectionAssert.AreEqual(new[] { 456 }, resolver.GetConcepts(123, null));
    }

    [TestMethod]
    public void Domain_UnknownConcept_Returns0()
    {
        var mappings = new Dictionary<int, IGrouping<int, ConceptCodeMapRow>>
        {
            {
                123,
                Group(123,
                    new ConceptCodeMapRow { source_concept_id = 123, target_concept_id = 456, source_domain_id = "Procedure", target_domain_id = "Procedure", mapped_from_standard = 0 })
            }
        };
        var resolver = CreateResolver(mappings);

        CollectionAssert.AreEqual(new[] { 0 }, resolver.GetConcepts(0, "Condition"));
    }

    [TestMethod]
    public void Domain_StandardConcept_CorrectDomain_ReturnsSelf()
    {
        var mappings = new Dictionary<int, IGrouping<int, ConceptCodeMapRow>>
        {
            {
                678,
                Group(678,
                    new ConceptCodeMapRow { source_concept_id = 678, target_concept_id = 678, source_domain_id = "Condition", target_domain_id = "Condition", mapped_from_standard = 1 })
            }
        };
        var resolver = CreateResolver(mappings);
        CollectionAssert.AreEqual(new[] { 678 }, resolver.GetConcepts(678, "Condition"));
    }

    [TestMethod]
    public void Domain_NonStandard_WithRelationship_CorrectDomain_ReturnsTarget()
    {
        var mappings = new Dictionary<int, IGrouping<int, ConceptCodeMapRow>>
        {
            {
                123,
                Group(123,
                    new ConceptCodeMapRow { source_concept_id = 123, target_concept_id = 456, source_domain_id = "Procedure", target_domain_id = "Procedure", mapped_from_standard = 0 })
            }
        };
        var resolver = CreateResolver(mappings);
        CollectionAssert.AreEqual(new[] { 456 }, resolver.GetConcepts(123, "Procedure"));
    }

    [TestMethod]
    public void Domain_NonStandard_NoRelationship_CorrectDomain_Returns0()
    {
        var mappings = new Dictionary<int, IGrouping<int, ConceptCodeMapRow>>
        {
            {
                123,
                Group(123,
                    new ConceptCodeMapRow { source_concept_id = 123, target_concept_id = null, source_domain_id = "Procedure", target_domain_id = null, mapped_from_standard = 0 })
            }
        };
        var resolver = CreateResolver(mappings);
        CollectionAssert.AreEqual(new[] { 0 }, resolver.GetConcepts(123, "Procedure"));
    }

    [TestMethod]
    public void Domain_StandardConcept_WrongDomain_ReturnsEmpty()
    {
        var mappings = new Dictionary<int, IGrouping<int, ConceptCodeMapRow>>
        {
            {
                678,
                Group(678,
                    new ConceptCodeMapRow { source_concept_id = 678, target_concept_id = 678, source_domain_id = "Condition", target_domain_id = "Condition", mapped_from_standard = 1 })
            }
        };
        var resolver = CreateResolver(mappings);
        CollectionAssert.AreEqual(Array.Empty<int>(), resolver.GetConcepts(678, "Procedure"));
    }

    [TestMethod]
    public void Domain_NonStandard_NoRelationship_WrongDomain_ReturnsEmpty()
    {
        var mappings = new Dictionary<int, IGrouping<int, ConceptCodeMapRow>>
        {
            {
                123,
                Group(123,
                    new ConceptCodeMapRow { source_concept_id = 123, target_concept_id = null, source_domain_id = "Procedure", target_domain_id = null, mapped_from_standard = 0 })
            }
        };
        var resolver = CreateResolver(mappings);
        CollectionAssert.AreEqual(Array.Empty<int>(), resolver.GetConcepts(123, "Condition"));
    }

    [TestMethod]
    public void Domain_NonStandard_WithRelationship_WrongDomain_ReturnsEmpty()
    {
        var mappings = new Dictionary<int, IGrouping<int, ConceptCodeMapRow>>
        {
            {
                123,
                Group(123,
                    new ConceptCodeMapRow { source_concept_id = 123, target_concept_id = 456, source_domain_id = "Procedure", target_domain_id = "Procedure", mapped_from_standard = 0 })
            }
        };
        var resolver = CreateResolver(mappings);
        CollectionAssert.AreEqual(Array.Empty<int>(), resolver.GetConcepts(123, "Condition"));
    }

    private sealed class Grouping<TKey, TElement> : IGrouping<TKey, TElement>
    {
        private readonly IEnumerable<TElement> _elements;
        public Grouping(TKey key, IEnumerable<TElement> elements)
        {
            Key = key;
            _elements = elements;
        }
        public TKey Key { get; }
        public IEnumerator<TElement> GetEnumerator() => _elements.GetEnumerator();
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => _elements.GetEnumerator();
    }
}
