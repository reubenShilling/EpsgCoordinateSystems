namespace EpsgCoordinateSystems.Other
{
    public class NAD83_HARN_Rhode_Island : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(HARN) / Rhode Island";
        public string Units => "Unspecified";
public long Srid => 2840;

        public string OgcWkt =>
            "PROJCS[NAD83(HARN) / Rhode Island,GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.08333333333334],PARAMETER[central_meridian,-71.5],PARAMETER[scale_factor,0.99999375],PARAMETER[false_easting,100000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2840],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83(HARN) / Rhode Island,GEOGCS[NAD83(HARN),DATUM[D_North_American_1983_HARN,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.08333333333334],PARAMETER[central_meridian,-71.5],PARAMETER[scale_factor,0.99999375],PARAMETER[false_easting,100000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}