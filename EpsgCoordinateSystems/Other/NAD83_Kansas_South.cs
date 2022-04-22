namespace EpsgCoordinateSystems.Other
{
    public class NAD83_Kansas_South : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / Kansas South";
        public string Units => "Unspecified";
public long Srid => 26978;

        public string OgcWkt =>
            "PROJCS[NAD83 / Kansas South,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,38.56666666666667],PARAMETER[standard_parallel_2,37.26666666666667],PARAMETER[latitude_of_origin,36.66666666666666],PARAMETER[central_meridian,-98.5],PARAMETER[false_easting,400000],PARAMETER[false_northing,400000],AUTHORITY[EPSG,26978],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83 / Kansas South,GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,38.56666666666667],PARAMETER[standard_parallel_2,37.26666666666667],PARAMETER[latitude_of_origin,36.66666666666666],PARAMETER[central_meridian,-98.5],PARAMETER[false_easting,400000],PARAMETER[false_northing,400000],UNIT[Meter,1]]";
    }
}