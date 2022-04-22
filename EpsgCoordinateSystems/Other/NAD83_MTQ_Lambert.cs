namespace EpsgCoordinateSystems.Other
{
    public class NAD83_MTQ_Lambert : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / MTQ Lambert";
        public string Units => "Unspecified";
public long Srid => 3798;

        public string OgcWkt =>
            "PROJCS[NAD83 / MTQ Lambert,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,50],PARAMETER[standard_parallel_2,46],PARAMETER[latitude_of_origin,44],PARAMETER[central_meridian,-70],PARAMETER[false_easting,800000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3798],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / MTQ Lambert,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,50],PARAMETER[standard_parallel_2,46],PARAMETER[latitude_of_origin,44],PARAMETER[central_meridian,-70],PARAMETER[false_easting,800000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3798],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}