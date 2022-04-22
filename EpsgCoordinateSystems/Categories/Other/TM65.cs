using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class TM65 : IEpsgCoordinateSystem
    {private const int _srid = 4299; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "TM65";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[TM65,DATUM[TM65,SPHEROID[Airy Modified 1849,6377340.189,299.3249646,AUTHORITY[EPSG,7002]],AUTHORITY[EPSG,6299]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4299]]";

        public string EsriWkt => "GEOGCS[TM65,DATUM[D_TM65,SPHEROID[Airy_Modified_1849,6377340.189,299.3249646]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}