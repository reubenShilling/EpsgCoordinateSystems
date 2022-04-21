namespace EpsgCoordinateSystems.Other
{
    public class NAD83_NSRS2007_Michigan_Oblique_Mercator : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(NSRS2007) / Michigan Oblique Mercator";
        public long Srid => 3591;

        public string OgcWkt =>
            "PROJCS[NAD83(NSRS2007) / Michigan Oblique Mercator,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,45.30916666666666],PARAMETER[longitude_of_center,-86],PARAMETER[azimuth,337.25556],PARAMETER[rectified_grid_angle,337.25556],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,2546731.496],PARAMETER[false_northing,-4354009.816],AUTHORITY[EPSG,3591],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(NSRS2007) / Michigan Oblique Mercator,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,45.30916666666666],PARAMETER[longitude_of_center,-86],PARAMETER[azimuth,337.25556],PARAMETER[rectified_grid_angle,337.25556],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,2546731.496],PARAMETER[false_northing,-4354009.816],AUTHORITY[EPSG,3591],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}