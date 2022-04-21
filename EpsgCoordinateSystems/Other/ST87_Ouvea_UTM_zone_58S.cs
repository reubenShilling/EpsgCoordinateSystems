namespace EpsgCoordinateSystems.Other
{
    public class ST87_Ouvea_UTM_zone_58S : IEpsgCoordinateSystem
    {
        public string Name => "ST87 Ouvea / UTM zone 58S";
        public long Srid => 3164;

        public string OgcWkt =>
            "PROJCS[ST87 Ouvea / UTM zone 58S,GEOGCS[ST87 Ouvea,DATUM[ST87_Ouvea,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[-56.263,16.136,-22.856,0,0,0,0],AUTHORITY[EPSG,6750]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4750]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,165],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3164],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[ST87 Ouvea / UTM zone 58S,GEOGCS[ST87 Ouvea,DATUM[ST87_Ouvea,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[-56.263,16.136,-22.856,0,0,0,0],AUTHORITY[EPSG,6750]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4750]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,165],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3164],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}