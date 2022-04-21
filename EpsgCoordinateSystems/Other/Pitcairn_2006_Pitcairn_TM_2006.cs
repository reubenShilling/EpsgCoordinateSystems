namespace EpsgCoordinateSystems.Other
{
    public class Pitcairn_2006_Pitcairn_TM_2006 : IEpsgCoordinateSystem
    {
        public string Name => "Pitcairn 2006 / Pitcairn TM 2006";
        public long Srid => 3783;

        public string OgcWkt =>
            "PROJCS[Pitcairn 2006 / Pitcairn TM 2006,GEOGCS[Pitcairn 2006,DATUM[Pitcairn_2006,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6763]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4763]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-25.06855261111111],PARAMETER[central_meridian,-130.1129671111111],PARAMETER[scale_factor,1],PARAMETER[false_easting,14200],PARAMETER[false_northing,15500],AUTHORITY[EPSG,3783],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Pitcairn 2006 / Pitcairn TM 2006,GEOGCS[Pitcairn 2006,DATUM[Pitcairn_2006,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6763]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4763]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-25.06855261111111],PARAMETER[central_meridian,-130.1129671111111],PARAMETER[scale_factor,1],PARAMETER[false_easting,14200],PARAMETER[false_northing,15500],AUTHORITY[EPSG,3783],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}