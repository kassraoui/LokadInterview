using Lokad_Interview.Models;

namespace Lokad_Interview.RateSources
{
    public interface IRateSource
    {
        string Name { get; }
        Task<IEnumerable<Rate>> FetchRates(DateOnly pnlDate);
    }
}
