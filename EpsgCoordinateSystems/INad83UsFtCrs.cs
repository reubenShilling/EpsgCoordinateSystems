using System;
using System.Collections.Generic;
using DotSpatial.Projections;
using EpsgCoordinateSystems.Categories;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems
{
    public interface INad83UsFtCrs
    {
        ProjectionInfo ProjectionInfo { get; }
        string Name { get; }
        string Description { get; }
        string Units { get; }
        int Srid { get; }
        Category Category { get; }
        string OgcWkt { get; }
        string EsriWkt { get; }
        List<LinearRing> Wgs84Boundaries { get; }
        BoundingBox BoundingBox { get; }
    }
}