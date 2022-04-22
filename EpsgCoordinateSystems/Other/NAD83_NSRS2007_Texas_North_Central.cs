namespace EpsgCoordinateSystems.Other
{
    public class NAD83_NSRS2007_Texas_North_Central : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(NSRS2007) / Texas North Central";
        public string Units => "Unspecified";
public long Srid => 3669;

        public string OgcWkt =>
            "PROJCS[NAD83(NSRS2007) / Texas North Central,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,33.96666666666667],PARAMETER[standard_parallel_2,32.13333333333333],PARAMETER[latitude_of_origin,31.66666666666667],PARAMETER[central_meridian,-98.5],PARAMETER[false_easting,600000],PARAMETER[false_northing,2000000],AUTHORITY[EPSG,3669],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(NSRS2007) / Texas North Central,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,33.96666666666667],PARAMETER[standard_parallel_2,32.13333333333333],PARAMETER[latitude_of_origin,31.66666666666667],PARAMETER[central_meridian,-98.5],PARAMETER[false_easting,600000],PARAMETER[false_northing,2000000],AUTHORITY[EPSG,3669],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}