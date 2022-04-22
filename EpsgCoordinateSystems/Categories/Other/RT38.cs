using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class RT38 : IEpsgCoordinateSystem
    {private const int _srid = 4308; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "RT38";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[RT38,DATUM[Stockholm_1938,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6308]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4308]]";

        public string EsriWkt => "GEOGCS[RT38,DATUM[D_Stockholm_1938,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}