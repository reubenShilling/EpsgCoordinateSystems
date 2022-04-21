namespace EpsgCoordinateSystems.Other
{
    public class IGN72_Nuku_Hiva_UTM_zone_7S : IEpsgCoordinateSystem
    {
        public string Name => "IGN72 Nuku Hiva / UTM zone 7S";
        public long Srid => 2978;

        public string OgcWkt =>
            "PROJCS[IGN72 Nuku Hiva / UTM zone 7S,GEOGCS[IGN72 Nuku Hiva,DATUM[IGN72_Nuku_Hiva,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6630]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4630]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-141],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,2978],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[IGN72 Nuku Hiva / UTM zone 7S,GEOGCS[IGN72 Nuku Hiva,DATUM[IGN72_Nuku_Hiva,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6630]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4630]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-141],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,2978],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}