namespace EpsgCoordinateSystems.Other
{
    public class NAD83_Florida_GDL_Albers : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / Florida GDL Albers";
        public string Units => "Unspecified";
public long Srid => 3086;

        public string OgcWkt =>
            "PROJCS[NAD83 / Florida GDL Albers,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,24],PARAMETER[standard_parallel_2,31.5],PARAMETER[latitude_of_center,24],PARAMETER[longitude_of_center,-84],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3086],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Florida GDL Albers,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,24],PARAMETER[standard_parallel_2,31.5],PARAMETER[latitude_of_center,24],PARAMETER[longitude_of_center,-84],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3086],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}