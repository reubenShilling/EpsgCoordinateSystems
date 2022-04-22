namespace EpsgCoordinateSystems.Other
{
    public class NAD83_Arkansas_North : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / Arkansas North";
        public string Units => "Unspecified";
public long Srid => 26951;

        public string OgcWkt =>
            "PROJCS[NAD83 / Arkansas North,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,36.23333333333333],PARAMETER[standard_parallel_2,34.93333333333333],PARAMETER[latitude_of_origin,34.33333333333334],PARAMETER[central_meridian,-92],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26951],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Arkansas North,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,36.23333333333333],PARAMETER[standard_parallel_2,34.93333333333333],PARAMETER[latitude_of_origin,34.33333333333334],PARAMETER[central_meridian,-92],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26951],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}