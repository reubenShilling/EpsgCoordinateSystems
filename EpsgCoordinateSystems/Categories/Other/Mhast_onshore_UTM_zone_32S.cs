namespace EpsgCoordinateSystems.Categories.Other
{
    public class Mhast_onshore_UTM_zone_32S : IEpsgCoordinateSystem
    {
        public string Name => "Mhast (onshore) / UTM zone 32S";
        public string Units => "Unspecified";
public int Srid => 3353;

        public string OgcWkt =>
            "PROJCS[Mhast (onshore) / UTM zone 32S,GEOGCS[Mhast (onshore),DATUM[Mhast_onshore,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6704]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4704]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3353],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Mhast (onshore) / UTM zone 32S,GEOGCS[Mhast (onshore),DATUM[D_Mhast_Onshore,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}