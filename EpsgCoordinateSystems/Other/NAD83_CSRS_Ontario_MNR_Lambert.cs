namespace EpsgCoordinateSystems.Other
{
    public class NAD83_CSRS_Ontario_MNR_Lambert : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(CSRS) / Ontario MNR Lambert";
        public string Units => "Unspecified";
public long Srid => 3162;

        public string OgcWkt =>
            "PROJCS[NAD83(CSRS) / Ontario MNR Lambert,GEOGCS[NAD83(CSRS),DATUM[NAD83_Canadian_Spatial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4617]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,44.5],PARAMETER[standard_parallel_2,53.5],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-85],PARAMETER[false_easting,930000],PARAMETER[false_northing,6430000],AUTHORITY[EPSG,3162],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83(CSRS) / Ontario MNR Lambert,GEOGCS[NAD83(CSRS),DATUM[D_North_American_1983_CSRS98,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,44.5],PARAMETER[standard_parallel_2,53.5],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-85],PARAMETER[false_easting,930000],PARAMETER[false_northing,6430000],UNIT[Meter,1]]";
    }
}