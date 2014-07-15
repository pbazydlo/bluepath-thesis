[ServiceContract]
public interface IRemoteWorkerService
{
    [OperationContract]
    void Init(int workerId);

    [OperationContract]
    void Map(Uri uri, Uri mapFuncUri);

    [OperationContract]
    void Reduce(Uri uri, Uri reduceFuncUri);

    [OperationContract]
    string[] TryJoin(int workerId, Uri callbackUri);

    [OperationContract]
    Uri[] TransferFiles(int workerId, Dictionary<string, Uri> keysAndUris);

    [OperationContract]
    Uri PushFile(int workerId, string fileName, string content);

    [OperationContract]
    PerformanceMonitor.PerformanceStatistics GetPerformanceStatistics();

    Uri EndpointUri { get; }
}