namespace EpsgCoordinateSystems
{
    public interface IEpsgCoordinateSystem
    {
        string Name { get; }
        string Units { get; }
        long Srid { get; }
        string OgcWkt { get; }
        string EsriWkt { get; }
    }
}