namespace EpsgCoordinateSystems.Other
{
    public class NAD83_California_zone_5 : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / California zone 5";
        public string Units => "Unspecified";
public long Srid => 26945;

        public string OgcWkt =>
            "PROJCS[NAD83 / California zone 5,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,35.46666666666667],PARAMETER[standard_parallel_2,34.03333333333333],PARAMETER[latitude_of_origin,33.5],PARAMETER[central_meridian,-118],PARAMETER[false_easting,2000000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,26945],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83 / California zone 5,GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,35.46666666666667],PARAMETER[standard_parallel_2,34.03333333333333],PARAMETER[latitude_of_origin,33.5],PARAMETER[central_meridian,-118],PARAMETER[false_easting,2000000],PARAMETER[false_northing,500000],UNIT[Meter,1]]";
    }
}