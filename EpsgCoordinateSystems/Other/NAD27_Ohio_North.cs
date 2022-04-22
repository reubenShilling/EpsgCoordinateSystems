namespace EpsgCoordinateSystems.Other
{
    public class NAD27_Ohio_North : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / Ohio North";
        public string Units => "Unspecified";
public long Srid => 32022;

        public string OgcWkt =>
            "PROJCS[NAD27 / Ohio North,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,40.43333333333333],PARAMETER[standard_parallel_2,41.7],PARAMETER[latitude_of_origin,39.66666666666666],PARAMETER[central_meridian,-82.5],PARAMETER[false_easting,2000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32022],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD27 / Ohio North,GEOGCS[GCS_North_American_1927,DATUM[D_North_American_1927,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,40.43333333333333],PARAMETER[standard_parallel_2,41.7],PARAMETER[latitude_of_origin,39.66666666666666],PARAMETER[central_meridian,-82.5],PARAMETER[false_easting,2000000],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";
    }
}