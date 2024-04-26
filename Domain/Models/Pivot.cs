namespace Domain.Models;

public class Pivot
{
    public int Id { get; set; }
    
    public TimeFrame TimeFrame { get; set; }
    
    public bool? HasTP { get; set; }
    
    public int OriginCandleId { get; set; }
    
    public int CoverCandleId { get; set; }
    
    public virtual Candle OriginCandle { get; set; }
    
    public virtual Candle CoverCandle { get; set; }
}