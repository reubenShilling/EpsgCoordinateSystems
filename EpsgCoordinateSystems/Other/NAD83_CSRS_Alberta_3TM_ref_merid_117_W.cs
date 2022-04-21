namespace EpsgCoordinateSystems.Other
{
    public class NAD83_CSRS_Alberta_3TM_ref_merid_117_W : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(CSRS) / Alberta 3TM ref merid 117 W";
        public long Srid => 3781;

        public string OgcWkt =>
            "PROJCS[NAD83(CSRS) / Alberta 3TM ref merid 117 W,GEOGCS[NAD83(CSRS),DATUM[NAD83_Canadian_Spatial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4617]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-117],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3781],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(CSRS) / Alberta 3TM ref merid 117 W,GEOGCS[NAD83(CSRS),DATUM[NAD83_Canadian_Spatial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4617]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-117],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3781],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}