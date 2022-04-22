namespace EpsgCoordinateSystems.Other
{
    public class Grand_Comoros_UTM_zone_38S : IEpsgCoordinateSystem
    {
        public string Name => "Grand Comoros / UTM zone 38S";
        public string Units => "Unspecified";
public long Srid => 2999;

        public string OgcWkt =>
            "PROJCS[Grand Comoros / UTM zone 38S,GEOGCS[Grand Comoros,DATUM[Grand_Comoros,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6646]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4646]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,45],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,2999],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Grand Comoros / UTM zone 38S,GEOGCS[Grand Comoros,DATUM[D_Grand_Comoros,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,45],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}