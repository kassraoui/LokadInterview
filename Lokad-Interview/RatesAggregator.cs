using Lokad_Interview.Models;
using Lokad_Interview.RateSources;
using System.Collections.Concurrent;

namespace Lokad_Interview
{
    public class RatesAggregator : IRatesAggregator
    {
        private readonly IEnumerable<IRateSource> _rateSources;

        public RatesAggregator(IEnumerable<IRateSource> rateSources)
        {
            _rateSources = rateSources ?? throw new ArgumentNullException(nameof(rateSources));
        }

        public IEnumerable<string> GetAllSourcesAsync() => _rateSources.Select(s => s.Name);

        public async Task<IEnumerable<Rate>> GetAllRates(DateOnly date)
        {
            var allRates = new ConcurrentBag<Rate>();
            //Use of ForEachAsync to allow a limited number of tasks in parrallel
            await Parallel.ForEachAsync(_rateSources, new ParallelOptions { MaxDegreeOfParallelism = 10 }, async (source, ct) =>
            {
                var rates = await source.FetchRates(date);
                foreach (var rate in rates)
                {
                    allRates.Add(rate);
                }
            });
            return allRates;
        }
    }
}
