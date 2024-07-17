namespace Songbird.Core.Configuration;

public record ProjectConfiguration {
    public string? Name { get; init; }
    public string? AccentColor { get; init; }
    public string? GroupName { get; init; }

    public IReadOnlyCollection<HealthCheckConfiguration>? HealthChecks { get; init; }
}
