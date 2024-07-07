using Lokad_Interview.Models;

namespace Lokad_Interview.RateSources.Carthage
{
    public class CarthageSource : ICarthageSource
    {
        private readonly ICarthageRateFromCsv _carthageRateFromCsv;

        public CarthageSource(ICarthageRateFromCsv carthageRateFromCsv)
        {
            _carthageRateFromCsv = carthageRateFromCsv ?? throw new ArgumentNullException(nameof(carthageRateFromCsv));
        }

        public string Name => "Carthage";

        public async Task<IEnumerable<Rate>> FetchRates(DateOnly pnlDate) 
            //Fetch rates from a CSV file received from Carthage
            => (await _carthageRateFromCsv.GetRatesFromCsv()).Select(Convert);

        private Rate Convert(CarthageCsvRate rate) => new()
        {
            Source = "Carthage",
            CurveName = rate.CurveName,
            PnlDate = rate.PnlDate,
            Value = rate.Value
        };
    }
}
