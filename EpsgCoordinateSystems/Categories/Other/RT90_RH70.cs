using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class RT90_RH70 : IEpsgCoordinateSystem
    {private const int _srid = 7404; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "RT90 + RH70";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "COMPD_CS[RT90 + RH70,GEOGCS[RT90,DATUM[Rikets koordinatsystem 1990,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[414.1,41.3,603.1,-0.855,-2.141,7.023,0.0],AUTHORITY[EPSG,6124]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4124]],VERT_CS[RH70,VERT_DATUM[Rikets hojdsystem 1970,2005,AUTHORITY[EPSG,5117]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5718]],AUTHORITY[EPSG,7404]]";

        public string EsriWkt => "COMPD_CS[RT90 + RH70,GEOGCS[RT90,DATUM[D_Rikets koordinatsystem 1990,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]],VERT_CS[RH70,VERT_DATUM[Rikets hojdsystem 1970,2005],UNIT[m,1.0]]]";
    }
}