namespace EpsgCoordinateSystems.Other
{
    public class Tahaa_54_UTM_zone_5S : IEpsgCoordinateSystem
    {
        public string Name => "Tahaa 54 / UTM zone 5S";
        public string Units => "Unspecified";
public long Srid => 2977;

        public string OgcWkt =>
            "PROJCS[Tahaa 54 / UTM zone 5S,GEOGCS[Tahaa 54,DATUM[Tahaa_54,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6629]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4629]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-153],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,2977],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Tahaa 54 / UTM zone 5S,GEOGCS[Tahaa 54,DATUM[D_Tahaa_1954,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-153],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}