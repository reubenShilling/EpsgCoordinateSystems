namespace EpsgCoordinateSystems.Other
{
    public class NAD27_Idaho_Central : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / Idaho Central";
        public long Srid => 26769;

        public string OgcWkt =>
            "PROJCS[NAD27 / Idaho Central,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.66666666666666],PARAMETER[central_meridian,-114],PARAMETER[scale_factor,0.999947368],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26769],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD27 / Idaho Central,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.66666666666666],PARAMETER[central_meridian,-114],PARAMETER[scale_factor,0.999947368],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26769],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}