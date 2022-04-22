namespace EpsgCoordinateSystems.Categories.Other
{
    public class ST84_Ile_des_Pins_UTM_zone_58S : IEpsgCoordinateSystem
    {
        public string Name => "ST84 Ile des Pins / UTM zone 58S";
        public string Units => "Unspecified";
public int Srid => 2996;

        public string OgcWkt =>
            "PROJCS[ST84 Ile des Pins / UTM zone 58S,GEOGCS[ST84 Ile des Pins,DATUM[ST84_Ile_des_Pins,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6642]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4642]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,165],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,2996],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[ST84 Ile des Pins / UTM zone 58S,GEOGCS[ST84 Ile des Pins,DATUM[D_ST84_Ile_des_Pins,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,165],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}