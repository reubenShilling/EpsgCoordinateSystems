using EpsgCoordinateSystems.Other;

namespace EpsgCoordinateSystems.Nad83HarnUsFt
{
    public class NAD83_HARN_Illinois_West_ftUS : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(HARN) / Illinois West (ftUS)";
        public long Srid => 3444;

        public string OgcWkt =>
            "PROJCS[NAD83(HARN) / Illinois West (ftUS),GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,36.66666666666666],PARAMETER[central_meridian,-90.16666666666667],PARAMETER[scale_factor,0.999941177],PARAMETER[false_easting,2296583.333300001],PARAMETER[false_northing,0],AUTHORITY[EPSG,3444],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(HARN) / Illinois West (ftUS),GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,36.66666666666666],PARAMETER[central_meridian,-90.16666666666667],PARAMETER[scale_factor,0.999941177],PARAMETER[false_easting,2296583.333300001],PARAMETER[false_northing,0],AUTHORITY[EPSG,3444],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}