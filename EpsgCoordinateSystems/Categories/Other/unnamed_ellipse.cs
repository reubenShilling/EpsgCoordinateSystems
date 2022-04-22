using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class unnamed_ellipse : IEpsgCoordinateSystem
    {private const int _srid = 4901; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "unnamed ellipse";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[unnamed ellipse,DATUM[unknown,SPHEROID[unnamed,6376523,308.6399999999995]],PRIMEM[paris,2.3372291666985],UNIT[degree,0.0174532925199433],AUTHORITY[EPSG,4901]]";

        public string EsriWkt => "GEOGCS[unnamed ellipse,DATUM[D_unknown,SPHEROID[Unknown,6376523,308.6399999999995]],PRIMEM[paris,2.3372291666985],UNIT[Degree,0.017453292519943295]]";
    }
}