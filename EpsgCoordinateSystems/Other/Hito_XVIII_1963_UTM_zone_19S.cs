namespace EpsgCoordinateSystems.Other
{
    public class Hito_XVIII_1963_UTM_zone_19S : IEpsgCoordinateSystem
    {
        public string Name => "Hito XVIII 1963 / UTM zone 19S";
        public string Units => "Unspecified";
public long Srid => 2084;

        public string OgcWkt =>
            "PROJCS[Hito XVIII 1963 / UTM zone 19S,GEOGCS[Hito XVIII 1963,DATUM[Hito_XVIII_1963,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6254]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4254]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-69],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,2084],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Hito XVIII 1963 / UTM zone 19S,GEOGCS[Hito XVIII 1963,DATUM[Hito_XVIII_1963,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6254]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4254]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-69],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,2084],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}