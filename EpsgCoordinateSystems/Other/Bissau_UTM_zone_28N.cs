namespace EpsgCoordinateSystems.Other
{
    public class Bissau_UTM_zone_28N : IEpsgCoordinateSystem
    {
        public string Name => "Bissau / UTM zone 28N";
        public long Srid => 2095;

        public string OgcWkt =>
            "PROJCS[Bissau / UTM zone 28N,GEOGCS[Bissau,DATUM[Bissau,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-173,253,27,0,0,0,0],AUTHORITY[EPSG,6165]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4165]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2095],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Bissau / UTM zone 28N,GEOGCS[Bissau,DATUM[Bissau,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-173,253,27,0,0,0,0],AUTHORITY[EPSG,6165]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4165]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2095],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}