namespace EpsgCoordinateSystems.Other
{
    public class NAD27_Cuba_Sur : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / Cuba Sur";
        public string Units => "Unspecified";
public long Srid => 3796;

        public string OgcWkt =>
            "PROJCS[NAD27 / Cuba Sur,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,21.3],PARAMETER[standard_parallel_2,20.13333333333333],PARAMETER[latitude_of_origin,20.71666666666667],PARAMETER[central_meridian,-76.83333333333333],PARAMETER[false_easting,500000],PARAMETER[false_northing,229126.939],AUTHORITY[EPSG,3796],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD27 / Cuba Sur,GEOGCS[GCS_North_American_1927,DATUM[D_North_American_1927,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,21.3],PARAMETER[standard_parallel_2,20.13333333333333],PARAMETER[latitude_of_origin,20.71666666666667],PARAMETER[central_meridian,-76.83333333333333],PARAMETER[false_easting,500000],PARAMETER[false_northing,229126.939],UNIT[Meter,1]]";
    }
}