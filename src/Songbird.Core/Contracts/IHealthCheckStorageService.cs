using Songbird.Core.Models;

namespace Songbird.Core.Contracts;

public interface IHealthCheckStorageService {
    Task StoreResultAsync(HealthCheckResult result);
}
