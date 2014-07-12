[ServiceContract]
public interface ICentralizedDiscoveryService
{
    [OperationContract]
    ServiceUri[] GetAvailableServices();

    [OperationContract]
    void Register(ServiceUri uri);

    [OperationContract]
    void Unregister(ServiceUri uri);

    [OperationContract]
    Task<Dictionary<ServiceUri, PerformanceStatistics>> GetPerformanceStatistics();
}