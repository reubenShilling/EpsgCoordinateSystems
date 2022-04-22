namespace EpsgCoordinateSystems.Other
{
    public class NAD27_CGQ77_SCoPQ_zone_6 : IEpsgCoordinateSystem
    {
        public string Name => "NAD27(CGQ77) / SCoPQ zone 6";
        public string Units => "Unspecified";
public long Srid => 2012;

        public string OgcWkt =>
            "PROJCS[NAD27(CGQ77) / SCoPQ zone 6,GEOGCS[NAD27(CGQ77),DATUM[North_American_Datum_1927_CGQ77,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6609]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4609]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-67.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,304800],PARAMETER[false_northing,0],AUTHORITY[EPSG,2012],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD27(CGQ77) / SCoPQ zone 6,GEOGCS[NAD27(CGQ77),DATUM[D_NAD_1927_CGQ77,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-67.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,304800],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}