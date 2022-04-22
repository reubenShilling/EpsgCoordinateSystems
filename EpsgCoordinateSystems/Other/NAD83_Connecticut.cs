namespace EpsgCoordinateSystems.Other
{
    public class NAD83_Connecticut : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / Connecticut";
        public string Units => "Unspecified";
public long Srid => 26956;

        public string OgcWkt =>
            "PROJCS[NAD83 / Connecticut,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,41.86666666666667],PARAMETER[standard_parallel_2,41.2],PARAMETER[latitude_of_origin,40.83333333333334],PARAMETER[central_meridian,-72.75],PARAMETER[false_easting,304800.6096],PARAMETER[false_northing,152400.3048],AUTHORITY[EPSG,26956],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83 / Connecticut,GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,41.86666666666667],PARAMETER[standard_parallel_2,41.2],PARAMETER[latitude_of_origin,40.83333333333334],PARAMETER[central_meridian,-72.75],PARAMETER[false_easting,304800.6096],PARAMETER[false_northing,152400.3048],UNIT[Meter,1]]";
    }
}