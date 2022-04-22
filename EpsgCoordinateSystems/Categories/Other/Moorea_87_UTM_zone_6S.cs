using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Moorea_87_UTM_zone_6S : IEpsgCoordinateSystem
    {private const int _srid = 3305; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Moorea 87 / UTM zone 6S";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Moorea 87 / UTM zone 6S,GEOGCS[Moorea 87,DATUM[Moorea_87,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[215.525,149.593,176.229,-3.2624,-1.692,-1.1571,10.4773],AUTHORITY[EPSG,6691]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4691]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-147],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3305],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Moorea 87 / UTM zone 6S,GEOGCS[Moorea 87,DATUM[D_Moorea_1987,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-147],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}