namespace Songbird.Core.Models;

public class HealthCheckResult {
    public HealthCheck? HealthCheck { get; init; }
    public DateTimeOffset? Timestamp { get; init; }
    public string? Environment { get; init; }
    public HealthCheckStatus Status { get; init; }
    public string? HealthCheckStatusDescription { get; init; }
    public TimeSpan? Duration { get; init; }
    public ICollection<HealthCheckResultEntry>? Entries { get; init; }
}

public class HealthCheckResultEntry {
    public string? Key { get; init; }
    public string? Description { get; init; }
    public TimeSpan? Duration { get; init; }
    public HealthCheckEntryStatus Status { get; init; }
    public string[]? Tags { get; init; }
}
