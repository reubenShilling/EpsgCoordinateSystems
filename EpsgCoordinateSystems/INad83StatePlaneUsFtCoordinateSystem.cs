using SharpKml.Dom;

namespace EpsgCoordinateSystems
{
    public interface INad83StatePlaneUsFtCoordinateSystem : IEpsgCoordinateSystem
    {
        LinearRing Wgs84Boundary { get; }
    }
}