namespace EpsgCoordinateSystems.Other
{
    public class NAD27_Wisconsin_South : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / Wisconsin South";
        public string Units => "Unspecified";
public long Srid => 32054;

        public string OgcWkt =>
            "PROJCS[NAD27 / Wisconsin South,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,42.73333333333333],PARAMETER[standard_parallel_2,44.06666666666667],PARAMETER[latitude_of_origin,42],PARAMETER[central_meridian,-90],PARAMETER[false_easting,2000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32054],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD27 / Wisconsin South,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,42.73333333333333],PARAMETER[standard_parallel_2,44.06666666666667],PARAMETER[latitude_of_origin,42],PARAMETER[central_meridian,-90],PARAMETER[false_easting,2000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32054],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}