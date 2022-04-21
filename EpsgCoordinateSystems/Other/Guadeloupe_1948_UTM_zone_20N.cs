namespace EpsgCoordinateSystems.Other
{
    public class Guadeloupe_1948_UTM_zone_20N : IEpsgCoordinateSystem
    {
        public string Name => "Guadeloupe 1948 / UTM zone 20N";
        public long Srid => 2970;

        public string OgcWkt =>
            "PROJCS[Guadeloupe 1948 / UTM zone 20N,GEOGCS[Guadeloupe 1948,DATUM[Guadeloupe_1948,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6622]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4622]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2970],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Guadeloupe 1948 / UTM zone 20N,GEOGCS[Guadeloupe 1948,DATUM[Guadeloupe_1948,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6622]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4622]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2970],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}