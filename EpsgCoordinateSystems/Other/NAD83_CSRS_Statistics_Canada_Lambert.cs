namespace EpsgCoordinateSystems.Other
{
    public class NAD83_CSRS_Statistics_Canada_Lambert : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(CSRS) / Statistics Canada Lambert";
        public string Units => "Unspecified";
public long Srid => 3348;

        public string OgcWkt =>
            "PROJCS[NAD83(CSRS) / Statistics Canada Lambert,GEOGCS[NAD83(CSRS),DATUM[NAD83_Canadian_Spatial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4617]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,49],PARAMETER[standard_parallel_2,77],PARAMETER[latitude_of_origin,63.390675],PARAMETER[central_meridian,-91.86666666666666],PARAMETER[false_easting,6200000],PARAMETER[false_northing,3000000],AUTHORITY[EPSG,3348],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(CSRS) / Statistics Canada Lambert,GEOGCS[NAD83(CSRS),DATUM[NAD83_Canadian_Spatial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4617]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,49],PARAMETER[standard_parallel_2,77],PARAMETER[latitude_of_origin,63.390675],PARAMETER[central_meridian,-91.86666666666666],PARAMETER[false_easting,6200000],PARAMETER[false_northing,3000000],AUTHORITY[EPSG,3348],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}