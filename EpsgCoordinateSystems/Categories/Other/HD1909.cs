using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class HD1909 : IEpsgCoordinateSystem
    {private const int _srid = 3819; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "HD1909";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[HD1909,DATUM[Hungarian Datum 1909,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[595.48,121.69,515.35,4.115,2.9383,-0.853,-0.7029504596901044],AUTHORITY[EPSG,1024]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,3819]]";

        public string EsriWkt => "GEOGCS[HD1909,DATUM[D_Hungarian Datum 1909,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}