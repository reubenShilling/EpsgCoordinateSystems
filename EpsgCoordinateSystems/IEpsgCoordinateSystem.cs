using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Dom;

namespace EpsgCoordinateSystems
{
    public interface IEpsgCoordinateSystem
    {
        ProjectionInfo ProjectionInfo { get; }
        string Name { get; }
        string Description { get; }
        string Units { get; }
        int Srid { get; }
        string OgcWkt { get; }
        string EsriWkt { get; }
        List<LinearRing> Wgs84Boundaries { get; }
    }
}