namespace EpsgCoordinateSystems.Other
{
    public class Pitcairn_1967_UTM_zone_9S : IEpsgCoordinateSystem
    {
        public string Name => "Pitcairn 1967 / UTM zone 9S";
        public string Units => "Unspecified";
public long Srid => 3784;

        public string OgcWkt =>
            "PROJCS[Pitcairn 1967 / UTM zone 9S,GEOGCS[Pitcairn 1967,DATUM[Pitcairn_1967,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[185,165,42,0,0,0,0],AUTHORITY[EPSG,6729]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4729]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-129],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3784],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Pitcairn 1967 / UTM zone 9S,GEOGCS[Pitcairn 1967,DATUM[Pitcairn_1967,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[185,165,42,0,0,0,0],AUTHORITY[EPSG,6729]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4729]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-129],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3784],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}