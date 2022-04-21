namespace EpsgCoordinateSystems.Other
{
    public class Hjorsey_1955_UTM_zone_28N : IEpsgCoordinateSystem
    {
        public string Name => "Hjorsey 1955 / UTM zone 28N";
        public long Srid => 3056;

        public string OgcWkt =>
            "PROJCS[Hjorsey 1955 / UTM zone 28N,GEOGCS[Hjorsey 1955,DATUM[Hjorsey_1955,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-73,46,-86,0,0,0,0],AUTHORITY[EPSG,6658]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4658]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3056],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Hjorsey 1955 / UTM zone 28N,GEOGCS[Hjorsey 1955,DATUM[Hjorsey_1955,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-73,46,-86,0,0,0,0],AUTHORITY[EPSG,6658]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4658]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3056],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}