using SharpKml.Dom;

namespace EpsgCoordinateSystems
{
    public interface INad83StatePlaneUsFtCoordinateSystem : IEpsgCoordinateSystem
    {
        Geometry Wgs84Boundary { get; }
    }
}