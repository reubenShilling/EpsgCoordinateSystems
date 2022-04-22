namespace EpsgCoordinateSystems.Other
{
    public class NAD83_CSRS_Yukon_Albers : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(CSRS) / Yukon Albers";
        public string Units => "Unspecified";
public long Srid => 3579;

        public string OgcWkt =>
            "PROJCS[NAD83(CSRS) / Yukon Albers,GEOGCS[NAD83(CSRS),DATUM[NAD83_Canadian_Spatial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4617]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,61.66666666666666],PARAMETER[standard_parallel_2,68],PARAMETER[latitude_of_center,59],PARAMETER[longitude_of_center,-132.5],PARAMETER[false_easting,500000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,3579],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83(CSRS) / Yukon Albers,GEOGCS[NAD83(CSRS),DATUM[D_North_American_1983_CSRS98,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Albers],PARAMETER[standard_parallel_1,61.66666666666666],PARAMETER[standard_parallel_2,68],PARAMETER[latitude_of_origin,59],PARAMETER[central_meridian,-132.5],PARAMETER[false_easting,500000],PARAMETER[false_northing,500000],UNIT[Meter,1]]";
    }
}