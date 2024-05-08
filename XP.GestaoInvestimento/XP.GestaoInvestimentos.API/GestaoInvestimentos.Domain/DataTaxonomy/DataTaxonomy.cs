using Microsoft.Extensions.Compliance.Classification;

namespace GestaoInvestimentos.Domain.DataTaxonomy
{
    public static class DataTaxonomy
    {
        public static string TaxonomyName { get; } = typeof(DataTaxonomy).FullName!;

        public static DataClassification SensitiveData { get; } = new(TaxonomyName, nameof(SensitiveData));
        //Pii -> Personal identifiable information
        public static DataClassification PiiData { get; } = new(TaxonomyName, nameof(PiiData));
    }

    public class SensitiveDataAttribute : DataClassificationAttribute
    {
        public SensitiveDataAttribute() : base(DataTaxonomy.SensitiveData)
        {
        }
    }
    public class PiiDataAttribute : DataClassificationAttribute
    {
        public PiiDataAttribute  () : base(DataTaxonomy.PiiData)
        {
        }
    }
}
