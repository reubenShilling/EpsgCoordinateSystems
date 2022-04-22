namespace EpsgCoordinateSystems.Other
{
    public class Qornoq_1927_UTM_zone_22N : IEpsgCoordinateSystem
    {
        public string Name => "Qornoq 1927 / UTM zone 22N";
        public string Units => "Unspecified";
public long Srid => 2216;

        public string OgcWkt =>
            "PROJCS[Qornoq 1927 / UTM zone 22N,GEOGCS[Qornoq 1927,DATUM[Qornoq_1927,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6194]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4194]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2216],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Qornoq 1927 / UTM zone 22N,GEOGCS[Qornoq 1927,DATUM[Qornoq_1927,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6194]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4194]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2216],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}