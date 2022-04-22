using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Makassar_NEIEZ : IEpsgCoordinateSystem
    {private const int _srid = 3002; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Makassar / NEIEZ";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Makassar / NEIEZ,GEOGCS[Makassar,DATUM[Makassar,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[-587.8,519.75,145.76,0,0,0,0],AUTHORITY[EPSG,6257]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4257]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Mercator_1SP],PARAMETER[central_meridian,110],PARAMETER[scale_factor,0.997],PARAMETER[false_easting,3900000],PARAMETER[false_northing,900000],AUTHORITY[EPSG,3002],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Makassar / NEIEZ,GEOGCS[Makassar,DATUM[D_Makassar,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Mercator],PARAMETER[central_meridian,110],PARAMETER[scale_factor,0.997],PARAMETER[false_easting,3900000],PARAMETER[false_northing,900000],UNIT[Meter,1]]";
    }
}