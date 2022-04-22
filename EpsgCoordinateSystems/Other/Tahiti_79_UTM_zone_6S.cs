namespace EpsgCoordinateSystems.Other
{
    public class Tahiti_79_UTM_zone_6S : IEpsgCoordinateSystem
    {
        public string Name => "Tahiti 79 / UTM zone 6S";
        public string Units => "Unspecified";
public long Srid => 3304;

        public string OgcWkt =>
            "PROJCS[Tahiti 79 / UTM zone 6S,GEOGCS[Tahiti 79,DATUM[Tahiti_79,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6690]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4690]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-147],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3304],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Tahiti 79 / UTM zone 6S,GEOGCS[Tahiti 79,DATUM[Tahiti_79,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6690]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4690]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-147],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3304],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}