namespace EpsgCoordinateSystems.Other
{
    public class RRAF_1991_UTM_zone_20N : IEpsgCoordinateSystem
    {
        public string Name => "RRAF 1991 / UTM zone 20N";
        public string Units => "Unspecified";
public long Srid => 2989;

        public string OgcWkt =>
            "PROJCS[RRAF 1991 / UTM zone 20N,GEOGCS[RRAF 1991,DATUM[Reseau_de_Reference_des_Antilles_Francaises_1991,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6640]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4640]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2989],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[RRAF 1991 / UTM zone 20N,GEOGCS[RRAF 1991,DATUM[Reseau_de_Reference_des_Antilles_Francaises_1991,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6640]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4640]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2989],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}