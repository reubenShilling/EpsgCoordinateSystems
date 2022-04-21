namespace EpsgCoordinateSystems.Other
{
    public class NAD27_Vermont : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / Vermont";
        public long Srid => 32045;

        public string OgcWkt =>
            "PROJCS[NAD27 / Vermont,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,42.5],PARAMETER[central_meridian,-72.5],PARAMETER[scale_factor,0.999964286],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32045],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD27 / Vermont,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,42.5],PARAMETER[central_meridian,-72.5],PARAMETER[scale_factor,0.999964286],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32045],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}