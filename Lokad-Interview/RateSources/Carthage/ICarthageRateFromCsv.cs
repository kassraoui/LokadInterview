using Lokad_Interview.Models;

namespace Lokad_Interview.RateSources.Carthage
{
    public interface ICarthageRateFromCsv
    {
        Task<IEnumerable<CarthageCsvRate>> GetRatesFromCsv();
    }
}
