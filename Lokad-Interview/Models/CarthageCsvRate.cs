namespace Lokad_Interview.Models
{
    public class CarthageCsvRate
    {
        public DateOnly PnlDate { get; init; }
        public string Source { get; init; }
        public string CurveName { get; init; }
        public decimal Value { get; init; }
    }
}
