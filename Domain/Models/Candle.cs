namespace Domain.Models;

public class Candle
{
    public int Id { get; set; }
    public double Open { get; set; }
    public double Close { get; set; }
    public double High { get; set; }
    public double Low { get; set; }
    public DateTime DateTime { get; set; }
    public TimeFrame TimeFrame { get; set; }
}