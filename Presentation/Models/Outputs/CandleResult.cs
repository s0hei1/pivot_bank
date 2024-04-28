using Domain.Models;

namespace Presentation.Models.Outputs;

public record CandleResult
    (
        double Open,
        double Close,
        double High,
        double Low,
        TimeFrame TimeFrame,
        DateTime DateTime
        );