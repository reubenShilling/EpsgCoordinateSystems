namespace EpsgCoordinateSystems.Other
{
    public class WGS_84_SCAR_IMW_SW01_60 : IEpsgCoordinateSystem
    {
        public string Name => "WGS 84 / SCAR IMW SW01-60";
        public string Units => "Unspecified";
public long Srid => 3293;

        public string OgcWkt =>
            "PROJCS[WGS 84 / SCAR IMW SW01-60,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Polar_Stereographic],PARAMETER[latitude_of_origin,-80.23861111111111],PARAMETER[central_meridian,0],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3293],AXIS[Easting,UNKNOWN],AXIS[Northing,UNKNOWN]]";

        public string EsriWkt =>
            "PROJCS[WGS 84 / SCAR IMW SW01-60,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Polar_Stereographic],PARAMETER[latitude_of_origin,-80.23861111111111],PARAMETER[central_meridian,0],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3293],AXIS[Easting,UNKNOWN],AXIS[Northing,UNKNOWN]]";
    }
}