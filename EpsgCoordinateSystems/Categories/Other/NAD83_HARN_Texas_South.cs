namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD83_HARN_Texas_South : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(HARN) / Texas South";
        public string Units => "Unspecified";
public int Srid => 2848;

        public string OgcWkt =>
            "PROJCS[NAD83(HARN) / Texas South,GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,27.83333333333333],PARAMETER[standard_parallel_2,26.16666666666667],PARAMETER[latitude_of_origin,25.66666666666667],PARAMETER[central_meridian,-98.5],PARAMETER[false_easting,300000],PARAMETER[false_northing,5000000],AUTHORITY[EPSG,2848],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83(HARN) / Texas South,GEOGCS[NAD83(HARN),DATUM[D_North_American_1983_HARN,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,27.83333333333333],PARAMETER[standard_parallel_2,26.16666666666667],PARAMETER[latitude_of_origin,25.66666666666667],PARAMETER[central_meridian,-98.5],PARAMETER[false_easting,300000],PARAMETER[false_northing,5000000],UNIT[Meter,1]]";
    }
}