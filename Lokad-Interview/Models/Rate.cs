namespace Lokad_Interview.Models
{
    public class Rate
    {
        public DateOnly PnlDate { get; init; }
        public string Source { get; init; }
        public string CurveName { get; init; }
        public decimal Value { get; init; }
    }
}
