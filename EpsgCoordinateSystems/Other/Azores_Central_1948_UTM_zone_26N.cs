namespace EpsgCoordinateSystems.Other
{
    public class Azores_Central_1948_UTM_zone_26N : IEpsgCoordinateSystem
    {
        public string Name => "Azores Central 1948 / UTM zone 26N";
        public long Srid => 2189;

        public string OgcWkt =>
            "PROJCS[Azores Central 1948 / UTM zone 26N,GEOGCS[Azores Central 1948,DATUM[Azores_Central_Islands_1948,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-104,167,-38,0,0,0,0],AUTHORITY[EPSG,6183]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4183]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-27],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2189],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Azores Central 1948 / UTM zone 26N,GEOGCS[Azores Central 1948,DATUM[Azores_Central_Islands_1948,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-104,167,-38,0,0,0,0],AUTHORITY[EPSG,6183]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4183]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-27],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2189],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}