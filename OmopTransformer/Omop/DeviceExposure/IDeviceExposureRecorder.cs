namespace OmopTransformer.Omop.DeviceExposure;

internal interface IDeviceExposureRecorder
{
    Task InsertUpdateDeviceExposure<T>(IReadOnlyCollection<OmopDeviceExposure<T>> records, string dataSource, CancellationToken cancellationToken);
}