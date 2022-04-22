namespace EpsgCoordinateSystems.Other
{
    public class NAD83_Utah_South : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / Utah South";
        public string Units => "Unspecified";
public long Srid => 32144;

        public string OgcWkt =>
            "PROJCS[NAD83 / Utah South,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,38.35],PARAMETER[standard_parallel_2,37.21666666666667],PARAMETER[latitude_of_origin,36.66666666666666],PARAMETER[central_meridian,-111.5],PARAMETER[false_easting,500000],PARAMETER[false_northing,3000000],AUTHORITY[EPSG,32144],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Utah South,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,38.35],PARAMETER[standard_parallel_2,37.21666666666667],PARAMETER[latitude_of_origin,36.66666666666666],PARAMETER[central_meridian,-111.5],PARAMETER[false_easting,500000],PARAMETER[false_northing,3000000],AUTHORITY[EPSG,32144],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}