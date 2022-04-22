using DotSpatial.Projections;

namespace EpsgCoordinateSystems
{
    public interface IEpsgCoordinateSystem
    {
        string Name { get; }
        string Units { get; }
        int Srid { get; }
        string OgcWkt { get; }
        string EsriWkt { get; }
    }
}