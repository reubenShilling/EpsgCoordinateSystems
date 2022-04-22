namespace EpsgCoordinateSystems.Other
{
    public class NAD27_Oregon_South : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / Oregon South";
        public string Units => "Unspecified";
public long Srid => 32027;

        public string OgcWkt =>
            "PROJCS[NAD27 / Oregon South,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,42.33333333333334],PARAMETER[standard_parallel_2,44],PARAMETER[latitude_of_origin,41.66666666666666],PARAMETER[central_meridian,-120.5],PARAMETER[false_easting,2000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32027],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD27 / Oregon South,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,42.33333333333334],PARAMETER[standard_parallel_2,44],PARAMETER[latitude_of_origin,41.66666666666666],PARAMETER[central_meridian,-120.5],PARAMETER[false_easting,2000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32027],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}