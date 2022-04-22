namespace EpsgCoordinateSystems.Other
{
    public class NAD83_Colorado_North : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / Colorado North";
        public string Units => "Unspecified";
public long Srid => 26953;

        public string OgcWkt =>
            "PROJCS[NAD83 / Colorado North,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,40.78333333333333],PARAMETER[standard_parallel_2,39.71666666666667],PARAMETER[latitude_of_origin,39.33333333333334],PARAMETER[central_meridian,-105.5],PARAMETER[false_easting,914401.8289],PARAMETER[false_northing,304800.6096],AUTHORITY[EPSG,26953],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Colorado North,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,40.78333333333333],PARAMETER[standard_parallel_2,39.71666666666667],PARAMETER[latitude_of_origin,39.33333333333334],PARAMETER[central_meridian,-105.5],PARAMETER[false_easting,914401.8289],PARAMETER[false_northing,304800.6096],AUTHORITY[EPSG,26953],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}