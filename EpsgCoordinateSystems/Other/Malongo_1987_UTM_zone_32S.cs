namespace EpsgCoordinateSystems.Other
{
    public class Malongo_1987_UTM_zone_32S : IEpsgCoordinateSystem
    {
        public string Name => "Malongo 1987 / UTM zone 32S";
        public string Units => "Unspecified";
public long Srid => 25932;

        public string OgcWkt =>
            "PROJCS[Malongo 1987 / UTM zone 32S,GEOGCS[Malongo 1987,DATUM[Malongo_1987,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6259]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4259]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,25932],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Malongo 1987 / UTM zone 32S,GEOGCS[Malongo 1987,DATUM[D_Malongo_1987,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}