namespace EpsgCoordinateSystems.Other
{
    public class NAD27_MTQ_Lambert : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / MTQ Lambert";
        public string Units => "Unspecified";
public long Srid => 3797;

        public string OgcWkt =>
            "PROJCS[NAD27 / MTQ Lambert,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,50],PARAMETER[standard_parallel_2,46],PARAMETER[latitude_of_origin,44],PARAMETER[central_meridian,-70],PARAMETER[false_easting,800000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3797],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD27 / MTQ Lambert,GEOGCS[GCS_North_American_1927,DATUM[D_North_American_1927,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,50],PARAMETER[standard_parallel_2,46],PARAMETER[latitude_of_origin,44],PARAMETER[central_meridian,-70],PARAMETER[false_easting,800000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}