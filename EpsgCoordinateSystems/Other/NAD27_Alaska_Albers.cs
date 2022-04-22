namespace EpsgCoordinateSystems.Other
{
    public class NAD27_Alaska_Albers : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / Alaska Albers";
        public string Units => "Unspecified";
public long Srid => 2964;

        public string OgcWkt =>
            "PROJCS[NAD27 / Alaska Albers,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,55],PARAMETER[standard_parallel_2,65],PARAMETER[latitude_of_center,50],PARAMETER[longitude_of_center,-154],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,2964],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD27 / Alaska Albers,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,55],PARAMETER[standard_parallel_2,65],PARAMETER[latitude_of_center,50],PARAMETER[longitude_of_center,-154],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,2964],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}