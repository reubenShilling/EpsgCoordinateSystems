namespace EpsgCoordinateSystems.Other
{
    public class NAD83_HARN_Hawaii_zone_3 : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(HARN) / Hawaii zone 3";
        public string Units => "Unspecified";
public long Srid => 2784;

        public string OgcWkt =>
            "PROJCS[NAD83(HARN) / Hawaii zone 3,GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,21.16666666666667],PARAMETER[central_meridian,-158],PARAMETER[scale_factor,0.99999],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2784],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(HARN) / Hawaii zone 3,GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,21.16666666666667],PARAMETER[central_meridian,-158],PARAMETER[scale_factor,0.99999],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2784],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}