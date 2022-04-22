namespace EpsgCoordinateSystems.Other
{
    public class Azores_Central_1995_UTM_zone_26N : IEpsgCoordinateSystem
    {
        public string Name => "Azores Central 1995 / UTM zone 26N";
        public string Units => "Unspecified";
public long Srid => 3063;

        public string OgcWkt =>
            "PROJCS[Azores Central 1995 / UTM zone 26N,GEOGCS[Azores Central 1995,DATUM[Azores_Central_Islands_1995,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6665]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4665]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-27],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3063],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Azores Central 1995 / UTM zone 26N,GEOGCS[Azores Central 1995,DATUM[Azores_Central_Islands_1995,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6665]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4665]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-27],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3063],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}