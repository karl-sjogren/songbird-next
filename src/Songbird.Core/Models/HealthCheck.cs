namespace Songbird.Core.Models;

public record HealthCheck {
    public Guid? Id { get; init; }
    public string? Name { get; init; }
    public string? Endpoint { get; init; }
    public string? Environment { get; init; }
    public IDictionary<string, string>? Headers { get; init; }
    public HealthCheckResponseType ResponseType { get; init; }
}
