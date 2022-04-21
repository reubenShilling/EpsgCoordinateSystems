namespace EpsgCoordinateSystems.Other
{
    public class NAD27_South_Carolina_South : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / South Carolina South";
        public long Srid => 32033;

        public string OgcWkt =>
            "PROJCS[NAD27 / South Carolina South,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,32.33333333333334],PARAMETER[standard_parallel_2,33.66666666666666],PARAMETER[latitude_of_origin,31.83333333333333],PARAMETER[central_meridian,-81],PARAMETER[false_easting,2000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32033],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD27 / South Carolina South,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,32.33333333333334],PARAMETER[standard_parallel_2,33.66666666666666],PARAMETER[latitude_of_origin,31.83333333333333],PARAMETER[central_meridian,-81],PARAMETER[false_easting,2000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32033],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}