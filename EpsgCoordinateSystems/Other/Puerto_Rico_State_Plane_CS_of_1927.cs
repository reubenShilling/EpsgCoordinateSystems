namespace EpsgCoordinateSystems.Other
{
    public class Puerto_Rico_State_Plane_CS_of_1927 : IEpsgCoordinateSystem
    {
        public string Name => "Puerto Rico State Plane CS of 1927";
        public long Srid => 3991;

        public string OgcWkt =>
            "PROJCS[Puerto Rico State Plane CS of 1927,GEOGCS[Puerto Rico,DATUM[Puerto_Rico,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[11,72,-101,0,0,0,0],AUTHORITY[EPSG,6139]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4139]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,18.43333333333333],PARAMETER[standard_parallel_2,18.03333333333333],PARAMETER[latitude_of_origin,17.83333333333333],PARAMETER[central_meridian,-66.43333333333334],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3991],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Puerto Rico State Plane CS of 1927,GEOGCS[Puerto Rico,DATUM[Puerto_Rico,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[11,72,-101,0,0,0,0],AUTHORITY[EPSG,6139]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4139]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,18.43333333333333],PARAMETER[standard_parallel_2,18.03333333333333],PARAMETER[latitude_of_origin,17.83333333333333],PARAMETER[central_meridian,-66.43333333333334],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3991],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}