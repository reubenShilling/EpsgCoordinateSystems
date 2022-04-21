namespace EpsgCoordinateSystems.Other
{
    public class NAD27_Cuba_Norte : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / Cuba Norte";
        public long Srid => 3795;

        public string OgcWkt =>
            "PROJCS[NAD27 / Cuba Norte,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,23],PARAMETER[standard_parallel_2,21.7],PARAMETER[latitude_of_origin,22.35],PARAMETER[central_meridian,-81],PARAMETER[false_easting,500000],PARAMETER[false_northing,280296.016],AUTHORITY[EPSG,3795],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD27 / Cuba Norte,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,23],PARAMETER[standard_parallel_2,21.7],PARAMETER[latitude_of_origin,22.35],PARAMETER[central_meridian,-81],PARAMETER[false_easting,500000],PARAMETER[false_northing,280296.016],AUTHORITY[EPSG,3795],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}