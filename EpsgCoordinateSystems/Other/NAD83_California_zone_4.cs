namespace EpsgCoordinateSystems.Other
{
    public class NAD83_California_zone_4 : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / California zone 4";
        public string Units => "Unspecified";
public long Srid => 26944;

        public string OgcWkt =>
            "PROJCS[NAD83 / California zone 4,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,37.25],PARAMETER[standard_parallel_2,36],PARAMETER[latitude_of_origin,35.33333333333334],PARAMETER[central_meridian,-119],PARAMETER[false_easting,2000000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,26944],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / California zone 4,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,37.25],PARAMETER[standard_parallel_2,36],PARAMETER[latitude_of_origin,35.33333333333334],PARAMETER[central_meridian,-119],PARAMETER[false_easting,2000000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,26944],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}