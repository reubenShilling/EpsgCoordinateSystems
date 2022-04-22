namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD83_North_Dakota_North : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / North Dakota North";
        public string Units => "Unspecified";
public int Srid => 32120;

        public string OgcWkt =>
            "PROJCS[NAD83 / North Dakota North,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,48.73333333333333],PARAMETER[standard_parallel_2,47.43333333333333],PARAMETER[latitude_of_origin,47],PARAMETER[central_meridian,-100.5],PARAMETER[false_easting,600000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32120],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83 / North Dakota North,GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,48.73333333333333],PARAMETER[standard_parallel_2,47.43333333333333],PARAMETER[latitude_of_origin,47],PARAMETER[central_meridian,-100.5],PARAMETER[false_easting,600000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}