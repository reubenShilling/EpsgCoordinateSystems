namespace EpsgCoordinateSystems
{
    public interface IEpsgCoordinateSystem
    {
        string Name { get; }
        long Srid { get; }
        string OgcWkt { get; }
        string EsriWkt { get; }
    }
}