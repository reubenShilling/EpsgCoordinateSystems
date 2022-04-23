using System.Collections.Generic;
using SharpKml.Dom;

namespace EpsgCoordinateSystems
{
    public interface INad83StatePlaneUsFtCoordinateSystem : IEpsgCoordinateSystem
    {
        List<LinearRing> Wgs84Boundaries { get; }
    }
}