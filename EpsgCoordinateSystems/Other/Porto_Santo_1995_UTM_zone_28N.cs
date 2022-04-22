namespace EpsgCoordinateSystems.Other
{
    public class Porto_Santo_1995_UTM_zone_28N : IEpsgCoordinateSystem
    {
        public string Name => "Porto Santo 1995 / UTM zone 28N";
        public string Units => "Unspecified";
public long Srid => 3061;

        public string OgcWkt =>
            "PROJCS[Porto Santo 1995 / UTM zone 28N,GEOGCS[Porto Santo 1995,DATUM[Porto_Santo_1995,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6663]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4663]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3061],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Porto Santo 1995 / UTM zone 28N,GEOGCS[Porto Santo 1995,DATUM[Porto_Santo_1995,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6663]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4663]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3061],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}