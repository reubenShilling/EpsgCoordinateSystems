namespace EpsgCoordinateSystems.Other
{
    public class NAD27_CGQ77_Quebec_Lambert : IEpsgCoordinateSystem
    {
        public string Name => "NAD27(CGQ77) / Quebec Lambert";
        public string Units => "Unspecified";
public long Srid => 2138;

        public string OgcWkt =>
            "PROJCS[NAD27(CGQ77) / Quebec Lambert,GEOGCS[NAD27(CGQ77),DATUM[North_American_Datum_1927_CGQ77,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6609]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4609]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,60],PARAMETER[standard_parallel_2,46],PARAMETER[latitude_of_origin,44],PARAMETER[central_meridian,-68.5],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,2138],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD27(CGQ77) / Quebec Lambert,GEOGCS[NAD27(CGQ77),DATUM[D_NAD_1927_CGQ77,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,60],PARAMETER[standard_parallel_2,46],PARAMETER[latitude_of_origin,44],PARAMETER[central_meridian,-68.5],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}