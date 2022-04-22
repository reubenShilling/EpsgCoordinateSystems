namespace EpsgCoordinateSystems.Other
{
    public class NAD83_NSRS2007_Rhode_Island : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(NSRS2007) / Rhode Island";
        public string Units => "Unspecified";
public long Srid => 3653;

        public string OgcWkt =>
            "PROJCS[NAD83(NSRS2007) / Rhode Island,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.08333333333334],PARAMETER[central_meridian,-71.5],PARAMETER[scale_factor,0.99999375],PARAMETER[false_easting,100000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3653],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83(NSRS2007) / Rhode Island,GEOGCS[NAD83(NSRS2007),DATUM[D_,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.08333333333334],PARAMETER[central_meridian,-71.5],PARAMETER[scale_factor,0.99999375],PARAMETER[false_easting,100000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}