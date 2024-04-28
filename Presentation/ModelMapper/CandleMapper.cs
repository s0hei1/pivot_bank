using Domain.Models;
using Presentation.Models.Outputs;

namespace Presentation.ModelMapper;

public static class CandleMapper
{
    public static CandleResult ToResult(this Candle candle)
    {
        var result = new CandleResult(
            Open: candle.Open,
            Close: candle.Close,
            High: candle.High,
            Low: candle.Low,
            TimeFrame: candle.TimeFrame,
            DateTime: candle.DateTime
        );

        return result;
    }

    public static List<CandleResult> ToResults(this List<Candle> candles)
    {
        var results = new List<CandleResult>();
        candles.ForEach(candle =>
        {
            results.Add(candle.ToResult());
        });

        return results;
    }
}