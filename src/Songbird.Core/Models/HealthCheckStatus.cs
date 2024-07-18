namespace Songbird.Core.Models;

public enum HealthCheckStatus {
    Unknown = 0,
    Unhealthy = 1,
    Degraded = 2,
    Healthy = 3,
}
