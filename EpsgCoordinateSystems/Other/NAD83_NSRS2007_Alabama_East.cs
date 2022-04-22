namespace EpsgCoordinateSystems.Other
{
    public class NAD83_NSRS2007_Alabama_East : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(NSRS2007) / Alabama East";
        public string Units => "Unspecified";
public long Srid => 3465;

        public string OgcWkt =>
            "PROJCS[NAD83(NSRS2007) / Alabama East,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,30.5],PARAMETER[central_meridian,-85.83333333333333],PARAMETER[scale_factor,0.99996],PARAMETER[false_easting,200000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3465],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(NSRS2007) / Alabama East,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,30.5],PARAMETER[central_meridian,-85.83333333333333],PARAMETER[scale_factor,0.99996],PARAMETER[false_easting,200000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3465],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}