namespace EpsgCoordinateSystems.Other
{
    public class Little_Cayman_1961_UTM_zone_17N : IEpsgCoordinateSystem
    {
        public string Name => "Little Cayman 1961 / UTM zone 17N";
        public long Srid => 3357;

        public string OgcWkt =>
            "PROJCS[Little Cayman 1961 / UTM zone 17N,GEOGCS[Little Cayman 1961,DATUM[Little_Cayman_1961,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6726]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4726]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-81],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3357],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Little Cayman 1961 / UTM zone 17N,GEOGCS[Little Cayman 1961,DATUM[Little_Cayman_1961,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6726]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4726]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-81],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3357],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}