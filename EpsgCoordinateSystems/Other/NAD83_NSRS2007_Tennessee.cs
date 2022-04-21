namespace EpsgCoordinateSystems.Other
{
    public class NAD83_NSRS2007_Tennessee : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(NSRS2007) / Tennessee";
        public long Srid => 3661;

        public string OgcWkt =>
            "PROJCS[NAD83(NSRS2007) / Tennessee,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,36.41666666666666],PARAMETER[standard_parallel_2,35.25],PARAMETER[latitude_of_origin,34.33333333333334],PARAMETER[central_meridian,-86],PARAMETER[false_easting,600000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3661],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(NSRS2007) / Tennessee,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,36.41666666666666],PARAMETER[standard_parallel_2,35.25],PARAMETER[latitude_of_origin,34.33333333333334],PARAMETER[central_meridian,-86],PARAMETER[false_easting,600000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3661],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}