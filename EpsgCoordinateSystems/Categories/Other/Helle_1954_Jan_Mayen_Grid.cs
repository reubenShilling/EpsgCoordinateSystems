namespace EpsgCoordinateSystems.Categories.Other
{
    public class Helle_1954_Jan_Mayen_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Helle 1954 / Jan Mayen Grid";
        public string Units => "Unspecified";
public int Srid => 3058;

        public string OgcWkt =>
            "PROJCS[Helle 1954 / Jan Mayen Grid,GEOGCS[Helle 1954,DATUM[Helle_1954,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[982.609,552.753,-540.873,32.3934,-153.257,-96.2266,16.805],AUTHORITY[EPSG,6660]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4660]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-8.5],PARAMETER[scale_factor,1],PARAMETER[false_easting,50000],PARAMETER[false_northing,-7800000],AUTHORITY[EPSG,3058],AXIS[y,EAST],AXIS[x,NORTH]]";

        public string EsriWkt => "PROJCS[Helle 1954 / Jan Mayen Grid,GEOGCS[Helle 1954,DATUM[D_Helle_1954,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-8.5],PARAMETER[scale_factor,1],PARAMETER[false_easting,50000],PARAMETER[false_northing,-7800000],UNIT[Meter,1]]";
    }
}