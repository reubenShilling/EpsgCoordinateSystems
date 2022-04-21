namespace EpsgCoordinateSystems.Other
{
    public class NAD83_Kentucky_North : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / Kentucky North";
        public long Srid => 2205;

        public string OgcWkt =>
            "PROJCS[NAD83 / Kentucky North,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,37.96666666666667],PARAMETER[standard_parallel_2,38.96666666666667],PARAMETER[latitude_of_origin,37.5],PARAMETER[central_meridian,-84.25],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2205],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Kentucky North,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,37.96666666666667],PARAMETER[standard_parallel_2,38.96666666666667],PARAMETER[latitude_of_origin,37.5],PARAMETER[central_meridian,-84.25],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2205],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}