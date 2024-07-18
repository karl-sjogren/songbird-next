namespace Songbird.Core.Models;

public record HealthCheckGroup {
    public string? Name { get; init; }
    public string? AccentColor { get; init; }

    public IReadOnlyCollection<HealthCheck>? HealthChecks { get; init; }
}
