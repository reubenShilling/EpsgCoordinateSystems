namespace EpsgCoordinateSystems.Other
{
    public class Porto_Santo_UTM_zone_28N : IEpsgCoordinateSystem
    {
        public string Name => "Porto Santo / UTM zone 28N";
        public string Units => "Unspecified";
public long Srid => 2942;

        public string OgcWkt =>
            "PROJCS[Porto Santo / UTM zone 28N,GEOGCS[Porto Santo,DATUM[Porto_Santo_1936,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-499,-249,314,0,0,0,0],AUTHORITY[EPSG,6615]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4615]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2942],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Porto Santo / UTM zone 28N,GEOGCS[Porto Santo,DATUM[Porto_Santo_1936,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-499,-249,314,0,0,0,0],AUTHORITY[EPSG,6615]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4615]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2942],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}