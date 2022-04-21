namespace EpsgCoordinateSystems.Other
{
    public class WGS_84_Dubai_Local_TM : IEpsgCoordinateSystem
    {
        public string Name => "WGS 84 / Dubai Local TM";
        public long Srid => 3997;

        public string OgcWkt =>
            "PROJCS[WGS 84 / Dubai Local TM,GEOGCS[WGS 84,DATUM[World Geodetic System 1984,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4326]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,55.33333333333333],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,1.0],PARAMETER[false_easting,500000.0],PARAMETER[false_northing,0.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,3997]]";

        public string EsriWkt =>
            "PROJCS[WGS 84 / Dubai Local TM,GEOGCS[WGS 84,DATUM[World Geodetic System 1984,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4326]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,55.33333333333333],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,1.0],PARAMETER[false_easting,500000.0],PARAMETER[false_northing,0.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,3997]]";
    }
}