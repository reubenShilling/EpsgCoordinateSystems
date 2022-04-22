namespace EpsgCoordinateSystems.Other
{
    public class NAD83_CSRS_NWT_Lambert : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(CSRS) / NWT Lambert";
        public string Units => "Unspecified";
public long Srid => 3581;

        public string OgcWkt =>
            "PROJCS[NAD83(CSRS) / NWT Lambert,GEOGCS[NAD83(CSRS),DATUM[NAD83_Canadian_Spatial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4617]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,62],PARAMETER[standard_parallel_2,70],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-112],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3581],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(CSRS) / NWT Lambert,GEOGCS[NAD83(CSRS),DATUM[NAD83_Canadian_Spatial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4617]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,62],PARAMETER[standard_parallel_2,70],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-112],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3581],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}