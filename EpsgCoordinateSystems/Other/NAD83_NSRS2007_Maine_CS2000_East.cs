namespace EpsgCoordinateSystems.Other
{
    public class NAD83_NSRS2007_Maine_CS2000_East : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(NSRS2007) / Maine CS2000 East";
        public string Units => "Unspecified";
public long Srid => 3555;

        public string OgcWkt =>
            "PROJCS[NAD83(NSRS2007) / Maine CS2000 East,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,43.83333333333334],PARAMETER[central_meridian,-67.875],PARAMETER[scale_factor,0.99998],PARAMETER[false_easting,700000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3555],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83(NSRS2007) / Maine CS2000 East,GEOGCS[NAD83(NSRS2007),DATUM[D_,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,43.83333333333334],PARAMETER[central_meridian,-67.875],PARAMETER[scale_factor,0.99998],PARAMETER[false_easting,700000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}