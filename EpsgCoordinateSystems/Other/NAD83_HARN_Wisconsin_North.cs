namespace EpsgCoordinateSystems.Other
{
    public class NAD83_HARN_Wisconsin_North : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(HARN) / Wisconsin North";
        public string Units => "Unspecified";
public long Srid => 2859;

        public string OgcWkt =>
            "PROJCS[NAD83(HARN) / Wisconsin North,GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,46.76666666666667],PARAMETER[standard_parallel_2,45.56666666666667],PARAMETER[latitude_of_origin,45.16666666666666],PARAMETER[central_meridian,-90],PARAMETER[false_easting,600000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2859],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(HARN) / Wisconsin North,GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,46.76666666666667],PARAMETER[standard_parallel_2,45.56666666666667],PARAMETER[latitude_of_origin,45.16666666666666],PARAMETER[central_meridian,-90],PARAMETER[false_easting,600000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2859],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}