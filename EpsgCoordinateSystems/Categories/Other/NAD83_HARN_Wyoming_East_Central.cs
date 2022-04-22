namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD83_HARN_Wyoming_East_Central : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(HARN) / Wyoming East Central";
        public string Units => "Unspecified";
public int Srid => 2863;

        public string OgcWkt =>
            "PROJCS[NAD83(HARN) / Wyoming East Central,GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40.5],PARAMETER[central_meridian,-107.3333333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,400000],PARAMETER[false_northing,100000],AUTHORITY[EPSG,2863],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83(HARN) / Wyoming East Central,GEOGCS[NAD83(HARN),DATUM[D_North_American_1983_HARN,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40.5],PARAMETER[central_meridian,-107.3333333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,400000],PARAMETER[false_northing,100000],UNIT[Meter,1]]";
    }
}