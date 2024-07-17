namespace Songbird.Core.Configuration;

public record HealthCheckConfiguration {
    public string? Name { get; init; }
    public string? Endpoint { get; init; }
    public IDictionary<string, string>? Headers { get; init; }
    public HealthCheckResponseType ResponseType { get; init; }
}
