namespace EpsgCoordinateSystems.Other
{
    public class Azores_Occidental_1939_UTM_zone_25N : IEpsgCoordinateSystem
    {
        public string Name => "Azores Occidental 1939 / UTM zone 25N";
        public string Units => "Unspecified";
public long Srid => 2188;

        public string OgcWkt =>
            "PROJCS[Azores Occidental 1939 / UTM zone 25N,GEOGCS[Azores Occidental 1939,DATUM[Azores_Occidental_Islands_1939,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6182]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4182]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-33],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2188],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Azores Occidental 1939 / UTM zone 25N,GEOGCS[Azores Occidental 1939,DATUM[D_Azores_Occidental_Islands_1939,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-33],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}