namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD27_76_UTM_zone_17N : IEpsgCoordinateSystem
    {
        public string Name => "NAD27(76) / UTM zone 17N";
        public string Units => "Unspecified";
public int Srid => 2029;

        public string OgcWkt =>
            "PROJCS[NAD27(76) / UTM zone 17N,GEOGCS[NAD27(76),DATUM[North_American_Datum_1927_1976,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6608]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4608]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-81],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2029],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[NAD27(76) / UTM zone 17N,GEOGCS[NAD27(76),DATUM[D_NAD_1927_Definition_1976,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-81],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}