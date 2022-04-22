namespace EpsgCoordinateSystems.Other
{
    public class NAD83_NSRS2007_Alaska_Albers : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(NSRS2007) / Alaska Albers";
        public string Units => "Unspecified";
public long Srid => 3467;

        public string OgcWkt =>
            "PROJCS[NAD83(NSRS2007) / Alaska Albers,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,55],PARAMETER[standard_parallel_2,65],PARAMETER[latitude_of_center,50],PARAMETER[longitude_of_center,-154],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3467],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(NSRS2007) / Alaska Albers,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,55],PARAMETER[standard_parallel_2,65],PARAMETER[latitude_of_center,50],PARAMETER[longitude_of_center,-154],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3467],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}