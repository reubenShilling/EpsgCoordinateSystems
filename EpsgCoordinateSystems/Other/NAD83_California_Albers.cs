namespace EpsgCoordinateSystems.Other
{
    public class NAD83_California_Albers : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / California Albers";
        public string Units => "Unspecified";
public long Srid => 3310;

        public string OgcWkt =>
            "PROJCS[NAD83 / California Albers,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,34],PARAMETER[standard_parallel_2,40.5],PARAMETER[latitude_of_center,0],PARAMETER[longitude_of_center,-120],PARAMETER[false_easting,0],PARAMETER[false_northing,-4000000],AUTHORITY[EPSG,3310],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / California Albers,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,34],PARAMETER[standard_parallel_2,40.5],PARAMETER[latitude_of_center,0],PARAMETER[longitude_of_center,-120],PARAMETER[false_easting,0],PARAMETER[false_northing,-4000000],AUTHORITY[EPSG,3310],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}