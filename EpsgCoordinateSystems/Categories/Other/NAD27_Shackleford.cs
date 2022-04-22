namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD27_Shackleford : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / Shackleford";
        public string Units => "Unspecified";
public int Srid => 3080;

        public string OgcWkt =>
            "PROJCS[NAD27 / Shackleford,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[foot,0.3048,AUTHORITY[EPSG,9002]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,27.41666666666667],PARAMETER[standard_parallel_2,34.91666666666666],PARAMETER[latitude_of_origin,31.16666666666667],PARAMETER[central_meridian,-100],PARAMETER[false_easting,3000000],PARAMETER[false_northing,3000000],AUTHORITY[EPSG,3080],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD27 / Shackleford,GEOGCS[GCS_North_American_1927,DATUM[D_North_American_1927,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,27.41666666666667],PARAMETER[standard_parallel_2,34.91666666666666],PARAMETER[latitude_of_origin,31.16666666666667],PARAMETER[central_meridian,-100],PARAMETER[false_easting,3000000],PARAMETER[false_northing,3000000],UNIT[Foot,0.3048]]";
    }
}