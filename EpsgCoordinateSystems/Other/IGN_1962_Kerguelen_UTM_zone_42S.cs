namespace EpsgCoordinateSystems.Other
{
    public class IGN_1962_Kerguelen_UTM_zone_42S : IEpsgCoordinateSystem
    {
        public string Name => "IGN 1962 Kerguelen / UTM zone 42S";
        public string Units => "Unspecified";
public long Srid => 3336;

        public string OgcWkt =>
            "PROJCS[IGN 1962 Kerguelen / UTM zone 42S,GEOGCS[IGN 1962 Kerguelen,DATUM[IGN_1962_Kerguelen,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[145,-187,103,0,0,0,0],AUTHORITY[EPSG,6698]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4698]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,69],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3336],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[IGN 1962 Kerguelen / UTM zone 42S,GEOGCS[IGN 1962 Kerguelen,DATUM[D_Kerguelen_Island_1949,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,69],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}