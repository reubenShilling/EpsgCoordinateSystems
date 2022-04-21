namespace EpsgCoordinateSystems.Other
{
    public class Nahrwan_1967_UTM_zone_38N : IEpsgCoordinateSystem
    {
        public string Name => "Nahrwan 1967 / UTM zone 38N";
        public long Srid => 27038;

        public string OgcWkt =>
            "PROJCS[Nahrwan 1967 / UTM zone 38N,GEOGCS[Nahrwan 1967,DATUM[Nahrwan_1967,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6270]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4270]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,45],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,27038],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Nahrwan 1967 / UTM zone 38N,GEOGCS[Nahrwan 1967,DATUM[Nahrwan_1967,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6270]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4270]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,45],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,27038],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}