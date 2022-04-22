namespace EpsgCoordinateSystems.Other
{
    public class NAD83_HARN_Ohio_South : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(HARN) / Ohio South";
        public string Units => "Unspecified";
public long Srid => 2835;

        public string OgcWkt =>
            "PROJCS[NAD83(HARN) / Ohio South,GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,40.03333333333333],PARAMETER[standard_parallel_2,38.73333333333333],PARAMETER[latitude_of_origin,38],PARAMETER[central_meridian,-82.5],PARAMETER[false_easting,600000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2835],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83(HARN) / Ohio South,GEOGCS[NAD83(HARN),DATUM[D_North_American_1983_HARN,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,40.03333333333333],PARAMETER[standard_parallel_2,38.73333333333333],PARAMETER[latitude_of_origin,38],PARAMETER[central_meridian,-82.5],PARAMETER[false_easting,600000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}