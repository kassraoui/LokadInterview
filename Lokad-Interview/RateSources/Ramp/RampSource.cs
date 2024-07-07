using Lokad_Interview.Models;

namespace Lokad_Interview.RateSources.Ramp
{
    public class RampSource : IRampSource
    {
        private readonly IRampRateClient rampRatesClient;

        public RampSource(IRampRateClient rampRatesClient)
        {
            this.rampRatesClient = rampRatesClient ?? throw new ArgumentNullException(nameof(rampRatesClient));
        }

        public string Name => "Ramp";

        public Task<IEnumerable<Rate>> FetchRates(DateOnly pnlDate)
        {
            //Fetch ramp rates from a database or external api ...
            throw new NotImplementedException();
        }
    }
}
