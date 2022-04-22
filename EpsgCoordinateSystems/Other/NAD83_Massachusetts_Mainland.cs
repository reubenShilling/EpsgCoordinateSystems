namespace EpsgCoordinateSystems.Other
{
    public class NAD83_Massachusetts_Mainland : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / Massachusetts Mainland";
        public string Units => "Unspecified";
public long Srid => 26986;

        public string OgcWkt =>
            "PROJCS[NAD83 / Massachusetts Mainland,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,42.68333333333333],PARAMETER[standard_parallel_2,41.71666666666667],PARAMETER[latitude_of_origin,41],PARAMETER[central_meridian,-71.5],PARAMETER[false_easting,200000],PARAMETER[false_northing,750000],AUTHORITY[EPSG,26986],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Massachusetts Mainland,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,42.68333333333333],PARAMETER[standard_parallel_2,41.71666666666667],PARAMETER[latitude_of_origin,41],PARAMETER[central_meridian,-71.5],PARAMETER[false_easting,200000],PARAMETER[false_northing,750000],AUTHORITY[EPSG,26986],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}