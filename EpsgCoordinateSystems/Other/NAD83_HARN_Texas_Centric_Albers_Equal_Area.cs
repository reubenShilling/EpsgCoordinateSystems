namespace EpsgCoordinateSystems.Other
{
    public class NAD83_HARN_Texas_Centric_Albers_Equal_Area : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(HARN) / Texas Centric Albers Equal Area";
        public long Srid => 3085;

        public string OgcWkt =>
            "PROJCS[NAD83(HARN) / Texas Centric Albers Equal Area,GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,27.5],PARAMETER[standard_parallel_2,35],PARAMETER[latitude_of_center,18],PARAMETER[longitude_of_center,-100],PARAMETER[false_easting,1500000],PARAMETER[false_northing,6000000],AUTHORITY[EPSG,3085],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83(HARN) / Texas Centric Albers Equal Area,GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,27.5],PARAMETER[standard_parallel_2,35],PARAMETER[latitude_of_center,18],PARAMETER[longitude_of_center,-100],PARAMETER[false_easting,1500000],PARAMETER[false_northing,6000000],AUTHORITY[EPSG,3085],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}