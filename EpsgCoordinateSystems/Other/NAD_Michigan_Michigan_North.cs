namespace EpsgCoordinateSystems.Other
{
    public class NAD_Michigan_Michigan_North : IEpsgCoordinateSystem
    {
        public string Name => "NAD Michigan / Michigan North";
        public long Srid => 26811;

        public string OgcWkt =>
            "PROJCS[NAD Michigan / Michigan North,GEOGCS[NAD27 Michigan,DATUM[NAD_Michigan,SPHEROID[Clarke 1866 Michigan,6378450.047548896,294.9786971646747,AUTHORITY[EPSG,7009]],AUTHORITY[EPSG,6268]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4268]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,45.48333333333333],PARAMETER[standard_parallel_2,47.08333333333334],PARAMETER[latitude_of_origin,44.78333333333333],PARAMETER[central_meridian,-87],PARAMETER[false_easting,2000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26811],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD Michigan / Michigan North,GEOGCS[NAD27 Michigan,DATUM[NAD_Michigan,SPHEROID[Clarke 1866 Michigan,6378450.047548896,294.9786971646747,AUTHORITY[EPSG,7009]],AUTHORITY[EPSG,6268]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4268]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,45.48333333333333],PARAMETER[standard_parallel_2,47.08333333333334],PARAMETER[latitude_of_origin,44.78333333333333],PARAMETER[central_meridian,-87],PARAMETER[false_easting,2000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26811],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}