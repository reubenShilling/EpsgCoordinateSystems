using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Dom;

namespace EpsgCoordinateSystems
{
    public abstract class Nad83StatePlaneUsFtCoordinateSystem : IEpsgCoordinateSystem
    {
        public virtual List<LinearRing> Wgs84Boundaries { get; }
        public virtual ProjectionInfo ProjectionInfo { get; }
        public virtual string Name { get; }
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public virtual string Units { get; }
        public virtual int Srid { get; }
        public virtual string OgcWkt { get; }
        public virtual string EsriWkt { get; }
    }
}