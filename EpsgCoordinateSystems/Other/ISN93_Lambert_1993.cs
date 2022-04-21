namespace EpsgCoordinateSystems.Other
{
    public class ISN93_Lambert_1993 : IEpsgCoordinateSystem
    {
        public string Name => "ISN93 / Lambert 1993";
        public long Srid => 3057;

        public string OgcWkt =>
            "PROJCS[ISN93 / Lambert 1993,GEOGCS[ISN93,DATUM[Islands_Network_1993,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6659]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4659]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,64.25],PARAMETER[standard_parallel_2,65.75],PARAMETER[latitude_of_origin,65],PARAMETER[central_meridian,-19],PARAMETER[false_easting,500000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,3057],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[ISN93 / Lambert 1993,GEOGCS[ISN93,DATUM[Islands_Network_1993,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6659]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4659]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,64.25],PARAMETER[standard_parallel_2,65.75],PARAMETER[latitude_of_origin,65],PARAMETER[central_meridian,-19],PARAMETER[false_easting,500000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,3057],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}