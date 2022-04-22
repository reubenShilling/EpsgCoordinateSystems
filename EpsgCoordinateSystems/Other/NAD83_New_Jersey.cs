namespace EpsgCoordinateSystems.Other
{
    public class NAD83_New_Jersey : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / New Jersey";
        public string Units => "Unspecified";
public long Srid => 32111;

        public string OgcWkt =>
            "PROJCS[NAD83 / New Jersey,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,38.83333333333334],PARAMETER[central_meridian,-74.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,150000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32111],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / New Jersey,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,38.83333333333334],PARAMETER[central_meridian,-74.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,150000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32111],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}