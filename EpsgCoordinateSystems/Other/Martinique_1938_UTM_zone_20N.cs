namespace EpsgCoordinateSystems.Other
{
    public class Martinique_1938_UTM_zone_20N : IEpsgCoordinateSystem
    {
        public string Name => "Martinique 1938 / UTM zone 20N";
        public string Units => "Unspecified";
public long Srid => 2973;

        public string OgcWkt =>
            "PROJCS[Martinique 1938 / UTM zone 20N,GEOGCS[Martinique 1938,DATUM[Martinique_1938,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6625]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4625]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2973],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Martinique 1938 / UTM zone 20N,GEOGCS[Martinique 1938,DATUM[Martinique_1938,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6625]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4625]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2973],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}