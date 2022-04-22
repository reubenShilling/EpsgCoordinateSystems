namespace EpsgCoordinateSystems.Other
{
    public class WGS_84_UTM_zone_60S : IEpsgCoordinateSystem
    {
        public string Name => "WGS 84 / UTM zone 60S";
        public string Units => "Unspecified";
public long Srid => 32760;

        public string OgcWkt =>
            "PROJCS[WGS 84 / UTM zone 60S,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,177],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,32760],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[WGS 84 / UTM zone 60S,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,177],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,32760],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}