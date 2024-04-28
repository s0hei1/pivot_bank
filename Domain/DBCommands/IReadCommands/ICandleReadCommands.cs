using Domain.Models;

namespace Domain.DBCommands.IReadCommands;

public interface ICandleReadCommands
{
    public Task<IQueryable<Candle>> GetCandles(TimeFrame timeFrame);
    
    public Task<Candle> GetCandleById(int candleId, TimeFrame timeFrame);

    public Task<IQueryable<Candle>> GetCandlesByRange(int firstItemId, int lastItemId, TimeFrame timeFrame);
    
    public Task<IQueryable<Candle>> GetCandlesByDateTimeRange(
        DateTime firstItemDateTime, 
        DateTime lastItemDateTime, 
        TimeFrame timeFrame
        );
}