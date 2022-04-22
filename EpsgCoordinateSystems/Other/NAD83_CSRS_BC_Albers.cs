namespace EpsgCoordinateSystems.Other
{
    public class NAD83_CSRS_BC_Albers : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(CSRS) / BC Albers";
        public string Units => "Unspecified";
public long Srid => 3153;

        public string OgcWkt =>
            "PROJCS[NAD83(CSRS) / BC Albers,GEOGCS[NAD83(CSRS),DATUM[NAD83_Canadian_Spatial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4617]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,50],PARAMETER[standard_parallel_2,58.5],PARAMETER[latitude_of_center,45],PARAMETER[longitude_of_center,-126],PARAMETER[false_easting,1000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3153],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(CSRS) / BC Albers,GEOGCS[NAD83(CSRS),DATUM[NAD83_Canadian_Spatial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4617]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,50],PARAMETER[standard_parallel_2,58.5],PARAMETER[latitude_of_center,45],PARAMETER[longitude_of_center,-126],PARAMETER[false_easting,1000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3153],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}