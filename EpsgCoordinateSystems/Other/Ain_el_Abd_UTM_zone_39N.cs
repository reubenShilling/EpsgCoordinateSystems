namespace EpsgCoordinateSystems.Other
{
    public class Ain_el_Abd_UTM_zone_39N : IEpsgCoordinateSystem
    {
        public string Name => "Ain el Abd / UTM zone 39N";
        public string Units => "Unspecified";
public long Srid => 20439;

        public string OgcWkt =>
            "PROJCS[Ain el Abd / UTM zone 39N,GEOGCS[Ain el Abd,DATUM[Ain_el_Abd_1970,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6204]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4204]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,20439],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Ain el Abd / UTM zone 39N,GEOGCS[Ain el Abd,DATUM[Ain_el_Abd_1970,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6204]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4204]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,20439],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}