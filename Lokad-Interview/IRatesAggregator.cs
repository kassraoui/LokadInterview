using Lokad_Interview.Models;

namespace Lokad_Interview
{
    public interface IRatesAggregator
    {
        IEnumerable<string> GetAllSourcesAsync();
        Task<IEnumerable<Rate>> GetAllRates(DateOnly date);
    }
}
