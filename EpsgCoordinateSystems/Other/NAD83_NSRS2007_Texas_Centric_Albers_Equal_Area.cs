namespace EpsgCoordinateSystems.Other
{
    public class NAD83_NSRS2007_Texas_Centric_Albers_Equal_Area : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(NSRS2007) / Texas Centric Albers Equal Area";
        public string Units => "Unspecified";
public long Srid => 3665;

        public string OgcWkt =>
            "PROJCS[NAD83(NSRS2007) / Texas Centric Albers Equal Area,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,27.5],PARAMETER[standard_parallel_2,35],PARAMETER[latitude_of_center,18],PARAMETER[longitude_of_center,-100],PARAMETER[false_easting,1500000],PARAMETER[false_northing,6000000],AUTHORITY[EPSG,3665],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(NSRS2007) / Texas Centric Albers Equal Area,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,27.5],PARAMETER[standard_parallel_2,35],PARAMETER[latitude_of_center,18],PARAMETER[longitude_of_center,-100],PARAMETER[false_easting,1500000],PARAMETER[false_northing,6000000],AUTHORITY[EPSG,3665],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}