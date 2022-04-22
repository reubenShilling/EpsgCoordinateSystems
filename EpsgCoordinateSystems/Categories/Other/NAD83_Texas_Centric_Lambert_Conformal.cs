namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD83_Texas_Centric_Lambert_Conformal : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / Texas Centric Lambert Conformal";
        public string Units => "Unspecified";
public int Srid => 3082;

        public string OgcWkt =>
            "PROJCS[NAD83 / Texas Centric Lambert Conformal,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,27.5],PARAMETER[standard_parallel_2,35],PARAMETER[latitude_of_origin,18],PARAMETER[central_meridian,-100],PARAMETER[false_easting,1500000],PARAMETER[false_northing,5000000],AUTHORITY[EPSG,3082],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83 / Texas Centric Lambert Conformal,GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,27.5],PARAMETER[standard_parallel_2,35],PARAMETER[latitude_of_origin,18],PARAMETER[central_meridian,-100],PARAMETER[false_easting,1500000],PARAMETER[false_northing,5000000],UNIT[Meter,1]]";
    }
}