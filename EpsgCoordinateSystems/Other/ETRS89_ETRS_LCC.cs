namespace EpsgCoordinateSystems.Other
{
    public class ETRS89_ETRS_LCC : IEpsgCoordinateSystem
    {
        public string Name => "ETRS89 / ETRS-LCC";
        public long Srid => 3034;

        public string OgcWkt =>
            "PROJCS[ETRS89 / ETRS-LCC,GEOGCS[ETRS89,DATUM[European_Terrestrial_Reference_System_1989,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4258]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,35],PARAMETER[standard_parallel_2,65],PARAMETER[latitude_of_origin,52],PARAMETER[central_meridian,10],PARAMETER[false_easting,4000000],PARAMETER[false_northing,2800000],AUTHORITY[EPSG,3034],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[ETRS89 / ETRS-LCC,GEOGCS[ETRS89,DATUM[European_Terrestrial_Reference_System_1989,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4258]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,35],PARAMETER[standard_parallel_2,65],PARAMETER[latitude_of_origin,52],PARAMETER[central_meridian,10],PARAMETER[false_easting,4000000],PARAMETER[false_northing,2800000],AUTHORITY[EPSG,3034],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}