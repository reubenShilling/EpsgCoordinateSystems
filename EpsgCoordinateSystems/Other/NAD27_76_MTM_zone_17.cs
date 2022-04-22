namespace EpsgCoordinateSystems.Other
{
    public class NAD27_76_MTM_zone_17 : IEpsgCoordinateSystem
    {
        public string Name => "NAD27(76) / MTM zone 17";
        public string Units => "Unspecified";
public long Srid => 2026;

        public string OgcWkt =>
            "PROJCS[NAD27(76) / MTM zone 17,GEOGCS[NAD27(76),DATUM[North_American_Datum_1927_1976,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6608]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4608]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-96],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,304800],PARAMETER[false_northing,0],AUTHORITY[EPSG,2026],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD27(76) / MTM zone 17,GEOGCS[NAD27(76),DATUM[North_American_Datum_1927_1976,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6608]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4608]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-96],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,304800],PARAMETER[false_northing,0],AUTHORITY[EPSG,2026],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}