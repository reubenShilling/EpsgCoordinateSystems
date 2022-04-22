namespace EpsgCoordinateSystems.Other
{
    public class NAD83_HARN_New_Mexico_East : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(HARN) / New Mexico East";
        public string Units => "Unspecified";
public long Srid => 2825;

        public string OgcWkt =>
            "PROJCS[NAD83(HARN) / New Mexico East,GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-104.3333333333333],PARAMETER[scale_factor,0.999909091],PARAMETER[false_easting,165000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2825],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(HARN) / New Mexico East,GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-104.3333333333333],PARAMETER[scale_factor,0.999909091],PARAMETER[false_easting,165000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2825],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}