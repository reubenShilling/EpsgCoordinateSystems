namespace EpsgCoordinateSystems.Other
{
    public class Mhast_offshore_UTM_zone_32S : IEpsgCoordinateSystem
    {
        public string Name => "Mhast (offshore) / UTM zone 32S";
        public string Units => "Unspecified";
public long Srid => 3354;

        public string OgcWkt =>
            "PROJCS[Mhast (offshore) / UTM zone 32S,GEOGCS[Mhast (offshore),DATUM[Mhast_offshore,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6705]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4705]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3354],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Mhast (offshore) / UTM zone 32S,GEOGCS[Mhast (offshore),DATUM[Mhast_offshore,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6705]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4705]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3354],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}