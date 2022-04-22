using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Massawa : IEpsgCoordinateSystem
    {private const int _srid = 4262; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Massawa";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Massawa,DATUM[Massawa,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[639,405,60,0,0,0,0],AUTHORITY[EPSG,6262]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4262]]";

        public string EsriWkt => "GEOGCS[Massawa,DATUM[D_Massawa,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}