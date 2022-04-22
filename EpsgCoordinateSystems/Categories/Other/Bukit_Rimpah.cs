using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Bukit_Rimpah : IEpsgCoordinateSystem
    {private const int _srid = 4219; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Bukit Rimpah";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Bukit Rimpah,DATUM[Bukit_Rimpah,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[-384,664,-48,0,0,0,0],AUTHORITY[EPSG,6219]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4219]]";

        public string EsriWkt => "GEOGCS[Bukit Rimpah,DATUM[D_Bukit_Rimpah,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}