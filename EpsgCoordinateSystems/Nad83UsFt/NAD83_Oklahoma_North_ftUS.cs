using EpsgCoordinateSystems.Other;

namespace EpsgCoordinateSystems.Nad83UsFt
{
    public class NAD83_Oklahoma_North_ftUS : IEpsgCoordinateSystem
    {
        public string Name => "Oklahoma North";
        public string Units => "US feet";
public long Srid => 2267;

        public string OgcWkt =>
            "PROJCS[NAD83 / Oklahoma North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,36.76666666666667],PARAMETER[standard_parallel_2,35.56666666666667],PARAMETER[latitude_of_origin,35],PARAMETER[central_meridian,-98],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,2267],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Oklahoma North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,36.76666666666667],PARAMETER[standard_parallel_2,35.56666666666667],PARAMETER[latitude_of_origin,35],PARAMETER[central_meridian,-98],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,2267],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}