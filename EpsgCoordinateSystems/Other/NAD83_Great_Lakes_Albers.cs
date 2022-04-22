namespace EpsgCoordinateSystems.Other
{
    public class NAD83_Great_Lakes_Albers : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / Great Lakes Albers";
        public string Units => "Unspecified";
public long Srid => 3174;

        public string OgcWkt =>
            "PROJCS[NAD83 / Great Lakes Albers,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,42.122774],PARAMETER[standard_parallel_2,49.01518],PARAMETER[latitude_of_center,45.568977],PARAMETER[longitude_of_center,-84.455955],PARAMETER[false_easting,1000000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,3174],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83 / Great Lakes Albers,GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Albers],PARAMETER[standard_parallel_1,42.122774],PARAMETER[standard_parallel_2,49.01518],PARAMETER[latitude_of_origin,45.568977],PARAMETER[central_meridian,-84.455955],PARAMETER[false_easting,1000000],PARAMETER[false_northing,1000000],UNIT[Meter,1]]";
    }
}