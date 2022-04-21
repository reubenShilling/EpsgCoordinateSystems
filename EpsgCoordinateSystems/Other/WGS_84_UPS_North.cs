namespace EpsgCoordinateSystems.Other
{
    public class WGS_84_UPS_North : IEpsgCoordinateSystem
    {
        public string Name => "WGS 84 / UPS North";
        public long Srid => 32661;

        public string OgcWkt =>
            "PROJCS[WGS 84 / UPS North,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Polar_Stereographic],PARAMETER[latitude_of_origin,90],PARAMETER[central_meridian,0],PARAMETER[scale_factor,0.994],PARAMETER[false_easting,2000000],PARAMETER[false_northing,2000000],AUTHORITY[EPSG,32661],AXIS[Easting,UNKNOWN],AXIS[Northing,UNKNOWN]]";

        public string EsriWkt =>
            "PROJCS[WGS 84 / UPS North,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Polar_Stereographic],PARAMETER[latitude_of_origin,90],PARAMETER[central_meridian,0],PARAMETER[scale_factor,0.994],PARAMETER[false_easting,2000000],PARAMETER[false_northing,2000000],AUTHORITY[EPSG,32661],AXIS[Easting,UNKNOWN],AXIS[Northing,UNKNOWN]]";
    }
}