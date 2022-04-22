namespace EpsgCoordinateSystems.Other
{
    public class Douala_1948_AEF_west : IEpsgCoordinateSystem
    {
        public string Name => "Douala 1948 / AEF west";
        public string Units => "Unspecified";
public long Srid => 3119;

        public string OgcWkt =>
            "PROJCS[Douala 1948 / AEF west,GEOGCS[Douala 1948,DATUM[Douala_1948,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-206.1,-174.7,-87.7,0,0,0,0],AUTHORITY[EPSG,6192]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4192]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,10.5],PARAMETER[scale_factor,0.999],PARAMETER[false_easting,1000000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,3119],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Douala 1948 / AEF west,GEOGCS[Douala 1948,DATUM[Douala_1948,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-206.1,-174.7,-87.7,0,0,0,0],AUTHORITY[EPSG,6192]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4192]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,10.5],PARAMETER[scale_factor,0.999],PARAMETER[false_easting,1000000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,3119],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}