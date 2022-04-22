namespace EpsgCoordinateSystems.Other
{
    public class NAD27_California_Albers : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / California Albers";
        public string Units => "Unspecified";
public long Srid => 3309;

        public string OgcWkt =>
            "PROJCS[NAD27 / California Albers,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,34],PARAMETER[standard_parallel_2,40.5],PARAMETER[latitude_of_center,0],PARAMETER[longitude_of_center,-120],PARAMETER[false_easting,0],PARAMETER[false_northing,-4000000],AUTHORITY[EPSG,3309],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD27 / California Albers,GEOGCS[GCS_North_American_1927,DATUM[D_North_American_1927,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Albers],PARAMETER[standard_parallel_1,34],PARAMETER[standard_parallel_2,40.5],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-120],PARAMETER[false_easting,0],PARAMETER[false_northing,-4000000],UNIT[Meter,1]]";
    }
}