using Domain.Models;

namespace Domain.DBCommands.IWriteCommands;

public interface ICandleWriteCommands
{
    public Task<Candle> AddCandles(List<Candle> candles);
}