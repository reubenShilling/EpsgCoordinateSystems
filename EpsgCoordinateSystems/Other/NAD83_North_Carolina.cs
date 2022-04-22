namespace EpsgCoordinateSystems.Other
{
    public class NAD83_North_Carolina : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / North Carolina";
        public string Units => "Unspecified";
public long Srid => 32119;

        public string OgcWkt =>
            "PROJCS[NAD83 / North Carolina,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,36.16666666666666],PARAMETER[standard_parallel_2,34.33333333333334],PARAMETER[latitude_of_origin,33.75],PARAMETER[central_meridian,-79],PARAMETER[false_easting,609601.22],PARAMETER[false_northing,0],AUTHORITY[EPSG,32119],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / North Carolina,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,36.16666666666666],PARAMETER[standard_parallel_2,34.33333333333334],PARAMETER[latitude_of_origin,33.75],PARAMETER[central_meridian,-79],PARAMETER[false_easting,609601.22],PARAMETER[false_northing,0],AUTHORITY[EPSG,32119],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}