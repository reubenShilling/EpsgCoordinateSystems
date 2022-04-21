namespace EpsgCoordinateSystems.Other
{
    public class NAD27_Arizona_Central : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / Arizona Central";
        public long Srid => 26749;

        public string OgcWkt =>
            "PROJCS[NAD27 / Arizona Central,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-111.9166666666667],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26749],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD27 / Arizona Central,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-111.9166666666667],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26749],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}