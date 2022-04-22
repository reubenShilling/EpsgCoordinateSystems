namespace EpsgCoordinateSystems.Other
{
    public class Tahiti_52_UTM_zone_6S : IEpsgCoordinateSystem
    {
        public string Name => "Tahiti 52 / UTM zone 6S";
        public string Units => "Unspecified";
public long Srid => 2976;

        public string OgcWkt =>
            "PROJCS[Tahiti 52 / UTM zone 6S,GEOGCS[Tahiti 52,DATUM[Tahiti_52,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[162,117,154,0,0,0,0],AUTHORITY[EPSG,6628]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4628]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-147],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,2976],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Tahiti 52 / UTM zone 6S,GEOGCS[Tahiti 52,DATUM[D_Tahiti_1952,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-147],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}