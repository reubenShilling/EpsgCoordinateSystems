namespace EpsgCoordinateSystems.Other
{
    public class NAD27_MTM_zone_5 : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / MTM zone 5";
        public string Units => "Unspecified";
public long Srid => 32085;

        public string OgcWkt =>
            "PROJCS[NAD27 / MTM zone 5,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-64.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,304800],PARAMETER[false_northing,0],AUTHORITY[EPSG,32085],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD27 / MTM zone 5,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-64.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,304800],PARAMETER[false_northing,0],AUTHORITY[EPSG,32085],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}