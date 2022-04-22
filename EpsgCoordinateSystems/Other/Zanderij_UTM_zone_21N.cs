namespace EpsgCoordinateSystems.Other
{
    public class Zanderij_UTM_zone_21N : IEpsgCoordinateSystem
    {
        public string Name => "Zanderij / UTM zone 21N";
        public string Units => "Unspecified";
public long Srid => 31121;

        public string OgcWkt =>
            "PROJCS[Zanderij / UTM zone 21N,GEOGCS[Zanderij,DATUM[Zanderij,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-265,120,-358,0,0,0,0],AUTHORITY[EPSG,6311]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4311]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,31121],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Zanderij / UTM zone 21N,GEOGCS[Zanderij,DATUM[Zanderij,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-265,120,-358,0,0,0,0],AUTHORITY[EPSG,6311]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4311]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,31121],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}