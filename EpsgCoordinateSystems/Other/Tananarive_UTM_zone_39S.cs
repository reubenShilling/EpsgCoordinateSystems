namespace EpsgCoordinateSystems.Other
{
    public class Tananarive_UTM_zone_39S : IEpsgCoordinateSystem
    {
        public string Name => "Tananarive / UTM zone 39S";
        public long Srid => 29739;

        public string OgcWkt =>
            "PROJCS[Tananarive / UTM zone 39S,GEOGCS[Tananarive,DATUM[Tananarive_1925,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-189,-242,-91,0,0,0,0],AUTHORITY[EPSG,6297]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4297]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,29739],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Tananarive / UTM zone 39S,GEOGCS[Tananarive,DATUM[Tananarive_1925,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-189,-242,-91,0,0,0,0],AUTHORITY[EPSG,6297]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4297]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,29739],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}