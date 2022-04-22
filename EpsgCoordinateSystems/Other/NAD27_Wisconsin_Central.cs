namespace EpsgCoordinateSystems.Other
{
    public class NAD27_Wisconsin_Central : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / Wisconsin Central";
        public string Units => "Unspecified";
public long Srid => 32053;

        public string OgcWkt =>
            "PROJCS[NAD27 / Wisconsin Central,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,44.25],PARAMETER[standard_parallel_2,45.5],PARAMETER[latitude_of_origin,43.83333333333334],PARAMETER[central_meridian,-90],PARAMETER[false_easting,2000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32053],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD27 / Wisconsin Central,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,44.25],PARAMETER[standard_parallel_2,45.5],PARAMETER[latitude_of_origin,43.83333333333334],PARAMETER[central_meridian,-90],PARAMETER[false_easting,2000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32053],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}