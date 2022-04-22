namespace EpsgCoordinateSystems.Other
{
    public class Ain_el_Abd_Aramco_Lambert : IEpsgCoordinateSystem
    {
        public string Name => "Ain el Abd / Aramco Lambert";
        public string Units => "Unspecified";
public long Srid => 2318;

        public string OgcWkt =>
            "PROJCS[Ain el Abd / Aramco Lambert,GEOGCS[Ain el Abd,DATUM[Ain_el_Abd_1970,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6204]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4204]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,17],PARAMETER[standard_parallel_2,33],PARAMETER[latitude_of_origin,25.08951],PARAMETER[central_meridian,48],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,2318],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Ain el Abd / Aramco Lambert,GEOGCS[Ain el Abd,DATUM[Ain_el_Abd_1970,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6204]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4204]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,17],PARAMETER[standard_parallel_2,33],PARAMETER[latitude_of_origin,25.08951],PARAMETER[central_meridian,48],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,2318],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}