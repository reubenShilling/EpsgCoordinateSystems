namespace EpsgCoordinateSystems.Other
{
    public class IGN72_Grande_Terre_UTM_zone_58S : IEpsgCoordinateSystem
    {
        public string Name => "IGN72 Grande Terre / UTM zone 58S";
        public string Units => "Unspecified";
public long Srid => 3060;

        public string OgcWkt =>
            "PROJCS[IGN72 Grande Terre / UTM zone 58S,GEOGCS[IGN72 Grande Terre,DATUM[IGN72_Grande_Terre,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6634]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4662]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,165],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3060],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[IGN72 Grande Terre / UTM zone 58S,GEOGCS[IGN72 Grande Terre,DATUM[D_IGN72_Grande_Terre,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,165],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}