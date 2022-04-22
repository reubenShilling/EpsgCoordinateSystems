using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Azores_Oriental_1940_UTM_zone_26N : IEpsgCoordinateSystem
    {private const int _srid = 2190; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Azores Oriental 1940 / UTM zone 26N";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Azores Oriental 1940 / UTM zone 26N,GEOGCS[Azores Oriental 1940,DATUM[Azores_Oriental_Islands_1940,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-203,141,53,0,0,0,0],AUTHORITY[EPSG,6184]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4184]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-27],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2190],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Azores Oriental 1940 / UTM zone 26N,GEOGCS[Azores Oriental 1940,DATUM[D_Azores_Oriental_Islands_1940,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-27],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}