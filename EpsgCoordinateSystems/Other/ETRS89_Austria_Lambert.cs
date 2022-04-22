namespace EpsgCoordinateSystems.Other
{
    public class ETRS89_Austria_Lambert : IEpsgCoordinateSystem
    {
        public string Name => "ETRS89 / Austria Lambert";
        public string Units => "Unspecified";
public long Srid => 3416;

        public string OgcWkt =>
            "PROJCS[ETRS89 / Austria Lambert,GEOGCS[ETRS89,DATUM[European_Terrestrial_Reference_System_1989,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4258]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,49],PARAMETER[standard_parallel_2,46],PARAMETER[latitude_of_origin,47.5],PARAMETER[central_meridian,13.33333333333333],PARAMETER[false_easting,400000],PARAMETER[false_northing,400000],AUTHORITY[EPSG,3416],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[ETRS89 / Austria Lambert,GEOGCS[ETRS89,DATUM[European_Terrestrial_Reference_System_1989,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4258]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,49],PARAMETER[standard_parallel_2,46],PARAMETER[latitude_of_origin,47.5],PARAMETER[central_meridian,13.33333333333333],PARAMETER[false_easting,400000],PARAMETER[false_northing,400000],AUTHORITY[EPSG,3416],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}