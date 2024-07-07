# LokadInterview

This is a simple example of data aggregation used to import rates from different sources
- Carthage rates : from a csv file
- Ramp Rates : from api calls

Those aggregated rates can then be stored on a DB for future calculations.

> **_NOTE:_** It is possible to include other sources simply by implementing *IRateSource* interface and injecting it in the *RatesAggregator* class
